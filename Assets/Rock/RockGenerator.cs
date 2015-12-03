using UnityEngine;
using System.Collections;


public class RockGenerator : MonoBehaviour {

    [SerializeField]
    private GameObject Rock1 = null;
    [SerializeField]
    private GameObject Rock2 = null;
    [SerializeField]
    private GameObject Rock3 = null;


	int[] EnemyTable;
	int[] EnemyCreateFream;

	int Count;


	// Use this for initialization
	void Start () {
        EnemyTable = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 2 };

		EnemyCreateFream = new int[]{120,120,120,120,120,120,150,150,180,240};

        Count = EnemyCreateFream[Random.Range(0, EnemyCreateFream.Length)];

	}
	
	// Update is called once per frame
	void Update () {


        Count--;

		//カウントがゼロになったら生成
		if (Count == 0) {

			//敵のタイプを決める
			int EnemyNum = EnemyTable[Random.Range(0,EnemyTable.Length)];

			//敵の出現座標のテーブルを作成する
			float[] PopPos = new float[]{1.5f,1.0f,0.5f,0.0f,-0.5f,-1.0f,-1.5f};

			//敵の出現座標を決める
			float PopPosition = PopPos[Random.Range(0,PopPos.Length)];

			//敵の生成部分
			switch(EnemyNum){
			case 0:
				Instantiate(Rock1,new Vector3(PopPosition,0.0f,8.0f),Quaternion.identity);
				break;

			case 1:
				Instantiate(Rock2,new Vector3(PopPosition,0.0f,8.0f),Quaternion.identity);
				break;

			case 2:
				Instantiate(Rock3,new Vector3(PopPosition,0.0f,8.0f),Quaternion.identity);
				break;


			}

            //カウントがゼロになったらカウントを取り直す
            Count = EnemyCreateFream[Random.Range(0, EnemyCreateFream.Length)];
		}








	}
}
