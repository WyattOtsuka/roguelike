using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mute : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int mute;

    public void Awake() {
        mute = PlayerPrefs.GetInt("vol");
        if (mute == 1) {
            text.text = "Mute All";
        } else {
            text.text = "Unmute All";
        }
    }

    public void OnClick(){
        if (mute == 0) {
            AudioListener.volume = 1;
            mute = 1;
            text.text = "Mute All";
        } else {
            AudioListener.volume = 0;
            mute = 0;
            text.text = "Unmute All";
        }
        PlayerPrefs.SetInt("vol", mute);
        PlayerPrefs.Save();
    }
}
