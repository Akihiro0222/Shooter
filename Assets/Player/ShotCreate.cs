using UnityEngine;
using System.Collections;

public class ShotCreate : MonoBehaviour {

    [SerializeField]
	public GameObject Shot;

    GameObject Player;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

		//Cが押されたときにPlayerの座標に生成される
		if(Input.GetKeyDown(KeyCode.C)){

            AudioManager.instance.PlaySoundShot();
			Instantiate(Shot,Player.transform.position,Quaternion.identity);



		}
	}
}
