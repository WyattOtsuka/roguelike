using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Enemy : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI text;

    System.Random rnd = new System.Random();

    void Awake() {
        health = rnd.Next(20,25);
        text.text = health.ToString();
    }

    public void UpdateHealth(int i) {
        health = health + i;
        text.text = health.ToString();
    }
}
