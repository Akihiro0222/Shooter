using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LimitTime : MonoBehaviour
{
	// 制限時間変数
	private float limitTime = 60;

	// 初期化
	void Start()
	{
		// 制限時間を60に初期化
		// float型からint型にキャスト String型に変換して表示
		GetComponent<Text> ().text = ((int)limitTime).ToString ();
	}
	
	// 更新
	void Update()
	{
		// １秒ずつ制限時間を1減らす
		limitTime -= Time.deltaTime;

		// 制限時間が0になったら
		if (limitTime < 0)
		{
			// マイナスは表示しない
			limitTime = 0;
			// ゲームクリア画面に遷移する
		}

		// 制限時間表示
		GetComponent<Text> ().text = ((int)limitTime).ToString ();
	}
}

// EOF