using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public int hp;
    public int maxHP;
    public int level;
    public int exp;

    public TextMeshProUGUI HPText;
    public TextMeshProUGUI ExpText;
    public TextMeshProUGUI LevelText;

    void Awake() {
        SaveSystem.Init();
        hp = 100;
        maxHP = 100;
        exp = 0;
        level = 1;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            save();
        } 
        if (Input.GetKeyDown(KeyCode.L)) {
            load();
        }

        // set texts
        HPText.text = hp + "/" + maxHP;
        ExpText.text = exp.ToString();
        LevelText.text = "Level " + level.ToString();

        if (exp >= 100) {
            level += exp / 100;
            exp = exp % 100;
        }
    }

    public void save() {
        saveObject s = new saveObject {
            hp = hp,
            level = level,
            exp = exp
        };
        string json = JsonUtility.ToJson(s);
        SaveSystem.save(json);
    }

    public void load() {
        string saveString = SaveSystem.load();
        if(saveString != null) {
            saveObject s = JsonUtility.FromJson<saveObject>(saveString);
            hp = s.hp;
            level = s.level;
            exp = s.exp;
        }
    }


    public void takeDamge(int dmg) {
        hp -= dmg;
    }

    public void addExp(int expGain) {
        exp += expGain;
    }

    private class saveObject {
        //public string[] inventory;
        public int hp;
        //public string[] deck;
        //public map; //find how to gernerate and to save
        public int level;
        public int exp;
    }
}
