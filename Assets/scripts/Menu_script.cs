using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_script : MonoBehaviour
{
    public GameObject settings;
    public Slider sensitivity_slider;
    public settings_script settings_Script;
    void Start()
    {
        Cursor.visible = true;
        if (settings.activeSelf == true)
        {
            settings.SetActive(false);
        }
        sensitivity_slider.value = settings_Script.sensitivity;
    }

    void Update()
    {
        //settings_Script.sensitivity = sensitivity_slider.value;
    }
    public void Settings()
    {
        settings.SetActive(true);
    }

    public void Back()
    {
        settings.SetActive(false);
    }
}

