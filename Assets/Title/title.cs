﻿using UnityEngine;
using System.Collections;

public class title : MonoBehaviour
{
	// 初期化
	void Start()
	{
	}
	
	// 更新
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Return))
		{
			Application.LoadLevel("PlayerMove");
		}
	}
}

// EOF