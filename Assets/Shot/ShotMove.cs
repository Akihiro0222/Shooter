using UnityEngine;
using System.Collections;

public class ShotMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 nowPos = transform.position;

		nowPos.z += 0.1f;

		transform.position = nowPos;

		if (transform.position.z > 8.0f) {
			Destroy(gameObject);
		}
	}
}
