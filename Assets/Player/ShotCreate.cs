using UnityEngine;
using System.Collections;

public class ShotCreate : MonoBehaviour {

    [SerializeField]
	public GameObject Shot;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//Cが押されたときにPlayerの座標に生成される
		if(Input.GetKeyDown(KeyCode.C)){
            //音声再生
            AudioManager.instance.PlaySoundShot();
            //弾の生成
			Instantiate(Shot,transform.position,Quaternion.identity);
		}
	}
}
