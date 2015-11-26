using UnityEngine;
using System.Collections;

public class ShotCreate : MonoBehaviour {

	public GameObject Shot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Cが押されたときにPlayerの座標に生成される
		if(Input.GetKeyDown(KeyCode.C)){

			GameObject Player = GameObject.Find("Player");

			Instantiate(Shot,Player.transform.position,Quaternion.identity);



		}
	}
}
