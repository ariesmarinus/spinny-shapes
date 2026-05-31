using UnityEngine;
using System.IO;

[CreateAssetMenu(fileName = "settings_script", menuName = "Scriptable Objects/settings_script")]
public class settings_script : ScriptableObject
{

    public float sensitivity;
    public float longest_time;
    public void Save()
    {
        string json = JsonUtility.ToJson(this);
        string path = Application.persistentDataPath + "/Data.json";
        File.WriteAllText(path, json);
    }



    public void Load()
    {
        string path = Application.persistentDataPath + "/Data.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
    public void UpdateSensitivity(Menu_script menu_Script)
    {
        sensitivity = menu_Script.sensitivity_slider.value;
    }

    
    
}
