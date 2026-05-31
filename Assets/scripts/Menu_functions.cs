using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Menu_functions", menuName = "Scriptable Objects/Menu_functions")]
public class Menu_functions : ScriptableObject
{
    public void Play()
    {
        SceneManager.LoadScene("level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Settings(Menu_script menu_Script)
    {
        menu_Script.settings.SetActive(true);
    }

    public void Back(Menu_script menu_Script)
    {
        menu_Script.settings.SetActive(false);
    }

    public void Continue()
    {
        SceneManager.LoadScene("level2");
    }
}
