using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public int hp;
    public int level;
    public int exp;

    void Awake() {
        SaveSystem.Init();
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

    private class saveObject {
        //public string[] inventory;
        public int hp;
        //public string[] deck;
        //public map; //find how to gernerate and to save
        public int level;
        public int exp;
    }
}
