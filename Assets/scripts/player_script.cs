using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class player_script : MonoBehaviour
{
    public camera_script camera_Script;
    public GameObject fell;
    public GameObject win;
    //public TMP_Text time;
    //public float timer;
    public settings_script settings_Script;
    void Start()
    {
        Cursor.visible = false;
        if (fell.activeSelf == true)
        {
            fell.SetActive(false);
        }
        if (win.activeSelf == true)
        {
            win.SetActive(false);
        }
    }

    void Update()
    {
        //timer += Time.deltaTime;
        //time.text = timer.ToString();
        //if (timer > settings_Script.longest_time)
        //{
        //    settings_Script.longest_time = timer;
        //}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
            Cursor.visible = true;
        }

        if (transform.position.y < -80)
        {
            fell.SetActive(true);
            Cursor.visible = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shape"))
        {
            camera_Script.jump_count = 0;
        }
        if (collision.gameObject.CompareTag("goal"))
        {
            Win();
        }
    }
    
    public void Win()
    {
        win.SetActive(true);
        Cursor.visible = true;
    }
}
