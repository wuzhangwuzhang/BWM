﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GX;

public class TableTest : MonoBehaviour
{
	void Start()
	{
		using (var mem = new MemoryStream(Resources.Load<TextAsset>("Table/TableItem").bytes))
		{
			// 忽略前面的 google.protobuf.FileDescriptorSet 元数据定义信息
			int descriptor;
			if (ProtoBuf.Serializer.TryReadLengthPrefix(mem, ProtoBuf.PrefixStyle.Base128, out descriptor))
			{
				mem.Seek(descriptor, SeekOrigin.Current);
				while (mem.Position < mem.Length)
				{
					var item = ProtoBuf.Serializer.DeserializeWithLengthPrefix<table.TableItemItem>(mem, ProtoBuf.PrefixStyle.Base128);
					Debug.Log(item.ToStringDebug());
				}
			}
		}
	}
}