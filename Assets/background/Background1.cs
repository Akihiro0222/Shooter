using UnityEngine;
using System.Collections;

public class Background1 : MonoBehaviour
{
	private float speed = -3;
	
	// 更新
	void Update()
	{
		Vector3 pos;
		pos = transform.localPosition;

		pos.y += speed;

		if (pos.y <= -500)
		{
			pos.y = 0;
		}

		transform.localPosition = pos;
	}
}

// EOF