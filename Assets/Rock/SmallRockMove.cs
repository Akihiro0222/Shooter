using UnityEngine;
using System.Collections;

public class SmallRockMove : MonoBehaviour {

    //初期の出現角度
    float Dir;

    //sinカーブを利用したうようよする岩を作るために使用
    float Dir2;


    [SerializeField]
    private int HP;

    // Use this for initialization
    void Start()
    {

        //下方向に向かって進むので、270を基準に方向を決める
        //画面外に出させないために少し幅を小さくする
        float[] DirTable = new float[] { 280.0f,  260.0f, 270.0f };

        Dir = DirTable[Random.Range(0, DirTable.Length)];
        Dir2 = 0;

        Vector3 angle = new Vector3();

        //回転しながら飛んでくるデブリなので初期の値をランダムにする
        angle.x = (float)Random.Range(0, 360);
        angle.y = (float)Random.Range(0, 360);
        angle.z = (float)Random.Range(0, 360);

        transform.eulerAngles = angle;


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 nowPos = transform.position;

        //画面外の枠に当たったら反射するように向きを変える
        if (nowPos.x > 2.0f)
            Dir = 270.0f + (270.0f - Dir);
        if (nowPos.x < -2.0f)
            Dir = 270.0f + (270.0f - Dir);

        //sinカーブのぶれ幅
        Dir2+=7f;
        if (Dir2 > 360f) Dir2 += 360f;


        const float MoveSpeed = 0.08f;

        //Y軸ではなくZ軸を使うため、sinはZ
        nowPos.x += Mathf.Cos(Dir2 * Mathf.Deg2Rad) * 0.03f;
        nowPos.z += Mathf.Sin(Dir * Mathf.Deg2Rad) * MoveSpeed;


        transform.position = nowPos;

        Vector3 angle = transform.eulerAngles;

        //回転させるための加算
        angle.x += 4.0f;
        //angle.y += 2.0f;
        angle.z += 4.0f;

        //上限設定
        if (angle.x >= 360.0f) angle.x -= 360.0f;
        if (angle.y >= 360.0f) angle.y -= 360.0f;
        if (angle.z >= 360.0f) angle.z -= 360.0f;



        transform.eulerAngles = angle;


    }

    void OnTriggerEnter(Collider collider)
    {

        HP--;


        if (HP <= 0)
        {
            AudioManager.instance.PlaySoundExprotion();
            Destroy(gameObject);
        }

    }

}
