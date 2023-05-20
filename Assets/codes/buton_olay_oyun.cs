using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay_oyun : MonoBehaviour
{
    public GameObject pause_panel;
    public GameObject olum_panel;
   
    public void durdur()
    {
        Time.timeScale = 0f;
        pause_panel.SetActive(true);
        
    }
    public void baslat()
    {
        Time.timeScale = 1f;
        pause_panel.SetActive(false);
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void restart()
    {
        SceneManager.LoadScene("oyun");
    }
    void Start()
    {
        pause_panel.SetActive(false);
        olum_panel.SetActive(false);

        Time.timeScale = 1f;
    }

   
    void Update()
    {
        

    }
}
