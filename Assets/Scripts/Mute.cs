using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mute : MonoBehaviour
{
    public TextMeshProUGUI text;
    private bool mute = false;
    public void OnClick(){
        if (mute) {
            AudioListener.volume = 1;
            mute = false;
            text.text = "Mute All";
        } else {
            AudioListener.volume = 0;
            mute = true;
            text.text = "Unmute All";
        }
    }
}
