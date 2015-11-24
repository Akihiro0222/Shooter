using UnityEngine;
using System.Collections;

public class KeyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//右への移動
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 nowPos = this.transform.position;
			nowPos.x = nowPos.x + 0.05f;
			if(nowPos.x <2.0f)
			this.transform.position=nowPos;
		}

		//左への移動
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 nowPos = this.transform.position;
			nowPos.x = nowPos.x - 0.05f;
			if(nowPos.x >-2.0f)
			this.transform.position=nowPos;
		}
	}
}
