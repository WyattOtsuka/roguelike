using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveSystem{

    private static readonly string SAVE_FOLDER = Application.dataPath + "/saves/";

    public static void Init(){
        // Check if directory exists   
        if (!Directory.Exists(SAVE_FOLDER)) {
            // Make if not
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }

    public static void save(string saveString){
        File.WriteAllText(SAVE_FOLDER + "/save.txt", saveString);
    }

    public static string load() {
        if (File.Exists(SAVE_FOLDER + "/save.txt")) {
            return File.ReadAllText(SAVE_FOLDER + "/save.txt");
        }
        return null;
    }
}