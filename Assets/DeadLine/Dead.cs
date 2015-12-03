using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    //デットラインにEnemyが触れたらシーンチェンジ
    void OnTriggerEnter(Collider collider)
    {

        Application.LoadLevel("GameOver");

    }

}
