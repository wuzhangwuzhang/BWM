﻿using UnityEngine;
using System.Collections;

public class CopyStart : MonoBehaviour {

	public GameObject uiBack;

	// Use this for initialization
	void Start () 
	{
		BattleScene.AddGuiToTop(gameObject, false);

		uiBack.GetComponent<TweenHeight>().AddOnFinished(onFinish);
	}

	void onFinish()
	{
		Destroy(transform.parent.gameObject);

		// 打开CopyEnd界面
		Instantiate(Resources.Load("Prefabs/Gui/CopyEnd"));
	}
}