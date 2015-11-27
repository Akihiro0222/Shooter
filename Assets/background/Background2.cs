using UnityEngine;
using System.Collections;

public class Background2 : MonoBehaviour
{
	private float speed = -3;
	
	// 更新
	void Update()
	{
		Vector3 pos;
		pos = transform.localPosition;
		
		pos.y += speed;
		
		if (pos.y <= 0)
		{
			pos.y = 500;
		}
		
		transform.localPosition = pos;
	}
}

// EOF