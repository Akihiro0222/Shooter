using UnityEngine;
using System.Collections;


public class RockGenerator : MonoBehaviour {

    [SerializeField]
    private GameObject Rock1 = null;
    [SerializeField]
    private GameObject Rock2 = null;
    [SerializeField]
    private GameObject Rock3 = null;

    EnemyTable Table;


	int Count;

    class EnemyTable
    {
        private int[] EnemyCreateType;
        private int[] EnemyCreateFream;

        private float[] EnemyPopPos;

        internal EnemyTable()
        {
            //敵のタイプを決定するテーブルを作成する
            EnemyCreateType = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 2 };

            //敵の出現するフレーム時間のテーブルを作成する
            EnemyCreateFream = new int[] { 120, 120, 120, 120, 120, 120, 150, 150, 180, 240 };

            //敵の出現座標のテーブルを作成する
            EnemyPopPos = new float[] { 1.5f, 1.0f, 0.5f, 0.0f, -0.5f, -1.0f, -1.5f };
        }

        internal int getRandomEnemyType()
        {
            return EnemyCreateType[Random.Range(0, EnemyCreateType.Length)];
        }

        internal int getRandomEnemyCreateFream()
        {
            return EnemyCreateFream[Random.Range(0, EnemyCreateFream.Length)];
        }

        internal float getRandomEnemyPopPosition()
        {
            return EnemyPopPos[Random.Range(0, EnemyPopPos.Length)];
        }
    }


	// Use this for initialization
	void Start () {

        Table = new EnemyTable();

        Count = Table.getRandomEnemyCreateFream();

	}
	
	// Update is called once per frame
	void Update () {


        Count--;

		//カウントがゼロになったら生成
		if (Count == 0) {

			//敵のタイプを決める
            int EnemyType = Table.getRandomEnemyType();



			//敵の出現座標を決める
            float PopPosition = Table.getRandomEnemyPopPosition();

			//敵の生成部分
            switch (EnemyType)
            {
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
            Count = Table.getRandomEnemyCreateFream();
		}

	}
}
