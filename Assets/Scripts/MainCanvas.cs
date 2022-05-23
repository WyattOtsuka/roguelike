using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public void Awake() {
        //load and set audio settings
        int mute;
        if (PlayerPrefs.HasKey("vol")){
            mute = PlayerPrefs.GetInt("vol");
        } else {
            mute = 1;
            PlayerPrefs.SetInt("vol", mute);
            PlayerPrefs.Save();
        }
        AudioListener.volume = mute;

        
    }
}
