using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    //シングルトン用の変数
    public static AudioManager instance = null;

    //再生したいソースを確保する
    [SerializeField]
    private AudioClip exprotion = null;
    [SerializeField]
    private AudioClip shot = null;


    //二種類の音を同時再生するために二つ用意する
    [SerializeField]
    private AudioSource audioSource_Shot;
    [SerializeField]
    private AudioSource audioSource_Exp;

	// Use this for initialization
	void Awake() {

        if (instance != null)
        {
            Destroy(instance.gameObject);
            instance = this;
        }
        else if (instance == null)
        {
            instance = this;
        }





	}
	
	// Update is called once per frame

    public void PlaySoundExprotion()
    {
        audioSource_Exp.clip = exprotion;

        audioSource_Exp.Play();
    }

    public void PlaySoundShot()
    {
        audioSource_Shot.clip = shot;

        audioSource_Shot.Play();
    }
}
