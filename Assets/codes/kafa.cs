using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kafa : MonoBehaviour
{
    public GameObject olum_panel;
    public GameObject araba;

    public int sonkonum;

    public Text olum_metre;

    public GameObject motor_ses;
    public GameObject arkaplan_ses;
    public GameObject olum_ses;

    public GameObject cay_al_but;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="zemin")
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("olum_sayi",PlayerPrefs.GetInt("olum_sayi")+1);
            if (PlayerPrefs.GetInt("olum_sayi")==2|| PlayerPrefs.GetInt("olum_sayi") == 4|| PlayerPrefs.GetInt("olum_sayi") == 6)
            {
                gecis_reklam.gecis_obje.GetComponent<gecis_reklam>().gecis_ad();
                
            }
            

            olum_ses.GetComponent<AudioSource>().Play();
            motor_ses.GetComponent<AudioSource>().Stop();
            arkaplan_ses.GetComponent<AudioSource>().Stop();
            Time.timeScale = 0f;
            sonkonum  = (int)araba.transform.position.x;
            olum_metre.text = sonkonum.ToString()+"M";
            olum_panel.SetActive(true);
        }
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("olum_sayi") > 6)
        {
            PlayerPrefs.SetInt("olum_sayi", 0);
        }
        if (PlayerPrefs.GetInt("olum_sayi") == 6)
        {
            cay_al_but.SetActive(true);
            PlayerPrefs.SetInt("olum_sayi", 0);
        }
        else
        {
            cay_al_but.SetActive(false);
        }
    }
}
