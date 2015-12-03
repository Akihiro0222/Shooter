using UnityEngine;
using System.Collections;

public class SystemSetting : MonoBehaviour {

	
    void Awake()
    {
        int WindowWidth = 1100;
        int WindowHeight = 1600;

        bool FullscreenFlag = false;

        int FreshRate = 60;

        Screen.SetResolution(WindowWidth, WindowHeight, FullscreenFlag,FreshRate);
    }
	

}
