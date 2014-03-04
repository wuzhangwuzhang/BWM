﻿using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(MapNav))]
public class MapNavEditor : Editor
{
	#region SerializedProperty
	/// <summary>
	/// 格子宽(米)
	/// </summary>
	private SerializedProperty gridWidth;
	/// <summary>
	/// 格子高(米)
	/// </summary>
	private SerializedProperty gridHeight;
	/// <summary>
	/// X轴格子数
	/// </summary>
	private SerializedProperty gridXNum;
	/// <summary>
	/// Z轴格子数
	/// </summary>
	private SerializedProperty gridZNum; 
	#endregion

	/// <summary>
	/// 当前修改的阻挡标志
	/// </summary>
	private MapNav.TileType curTileType = MapNav.TileType.Walk;
	/// <summary>
	/// 当前操作类型
	/// </summary>
	private ProcessType curProcessType = ProcessType.None;
	/// <summary>
	/// 操作直径
	/// </summary>
	private int radius = 1;

	public MapNav Target { get { return (MapNav)target; } }

	/// <summary>
	/// 操作类型
	/// </summary>
	public enum ProcessType
	{
		/// <summary>
		/// 没有操作
		/// </summary>
		None = 0,
		/// <summary>
		/// 设置
		/// </summary>
		Set = 1,
		/// <summary>
		/// 清空
		/// </summary>
		Clear = 2,
	}

	void OnEnable()
	{
		gridWidth = serializedObject.FindProperty("gridWidth");
		gridHeight = serializedObject.FindProperty("gridHeight");
		gridXNum = serializedObject.FindProperty("gridXNum");
		gridZNum = serializedObject.FindProperty("gridZNum");
	}

	public override void OnInspectorGUI()
	{
		Tools.current = Tool.View;

		EditorGUILayout.Space();
		serializedObject.Update();

		Target.showGrids = EditorGUILayout.BeginToggleGroup("显示格子", Target.showGrids);
		if (Target.showGrids)
		{
			EditorGUILayout.PropertyField(gridWidth, new GUIContent("格子宽(米)"));
			EditorGUILayout.PropertyField(gridHeight, new GUIContent("格子高(米)"));
			EditorGUILayout.PropertyField(gridXNum, new GUIContent("X轴格子数"));
			EditorGUILayout.PropertyField(gridZNum, new GUIContent("Z轴格子数"));
			if (GUILayout.Button("Update"))
			{
				Target.Reset();
			}

			this.curProcessType = (ProcessType)EditorGUILayout.EnumPopup("当前操作类型", this.curProcessType);
			this.curTileType = (MapNav.TileType)EditorGUILayout.EnumPopup("当前格子类型", this.curTileType);
			this.radius = EditorGUILayout.IntSlider("操作直径", this.radius, 1, 16);

			EditorUtility.SetDirty(this.target);
		}
		EditorGUILayout.EndToggleGroup();

		serializedObject.ApplyModifiedProperties();
	}

	public void OnSceneGUI()
	{
		MapNav mapNav = Target;
		float y = 0.1f;
		if (curProcessType == ProcessType.None)
			return;

		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
		float rayDistance;
		Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
		if (groundPlane.Raycast(ray, out rayDistance))
		{
			Vector3 hitPoint = ray.GetPoint(rayDistance);
			if (hitPoint.x >= 0.0f && hitPoint.x <= mapNav.gridXNum * mapNav.gridWidth
			   && hitPoint.z >= 0.0f && hitPoint.z <= mapNav.gridZNum * mapNav.gridHeight)
			{
				Handles.color = Color.white;
				float _radius = radius * 0.5f;
				Handles.DrawPolyLine(new Vector3[]
				{
					new Vector3(hitPoint.x - _radius * mapNav.gridWidth, y, hitPoint.z - _radius * mapNav.gridHeight),
					new Vector3(hitPoint.x - _radius * mapNav.gridWidth, y, hitPoint.z + _radius * mapNav.gridHeight),
					new Vector3(hitPoint.x + _radius * mapNav.gridWidth, y, hitPoint.z + _radius * mapNav.gridHeight),
					new Vector3(hitPoint.x + _radius * mapNav.gridWidth, y, hitPoint.z - _radius * mapNav.gridHeight),
					new Vector3(hitPoint.x - _radius * mapNav.gridWidth, y, hitPoint.z - _radius * mapNav.gridHeight)
				});

				if (Event.current.type == EventType.MouseDown || Event.current.type == EventType.MouseDrag)
				{
					int x = mapNav.getX(hitPoint);
					int z = mapNav.getZ(hitPoint);
					for (int _z = z - Mathf.RoundToInt(_radius); _z <= z + Mathf.RoundToInt(_radius); ++_z)
					{
						if (_z < 0) continue;
						if (_z > mapNav.gridZNum - 1) continue;
						for (int _x = x - Mathf.RoundToInt(_radius); _x <= x + Mathf.RoundToInt(_radius); ++_x)
						{
							if (_x < 0) continue;
							if (_x > mapNav.gridXNum - 1) continue;

							Vector3 position = mapNav.getPosition(_x, _z);
							if (Mathf.Abs(position.x - hitPoint.x) <= _radius * mapNav.gridWidth
							   && Mathf.Abs(position.z - hitPoint.z) <= _radius * mapNav.gridHeight)
							{
								switch (curProcessType)
								{
									case ProcessType.None:
										break;
									case ProcessType.Set:
										mapNav[_x, _z] |= curTileType;
										break;
									case ProcessType.Clear:
										mapNav[_x, _z] &= ~curTileType;
										break;
									default:
										throw new System.NotImplementedException();
								}
							}
						}
					}
				}
			}
		}

		HandleUtility.Repaint();
		switch (Event.current.type)
		{
			case EventType.MouseUp:
			case EventType.MouseDown:
			case EventType.MouseDrag:
			case EventType.MouseMove:
				Event.current.Use();
				break;
		}
	}
}
