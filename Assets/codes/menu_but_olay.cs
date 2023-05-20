using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_but_olay : MonoBehaviour
{
    public GameObject shop_panel;
    public GameObject tofas;
    public GameObject honda;
    public GameObject subuwu;

    public GameObject sol_button;
    public GameObject sag_button;

    int sag_basma = 0;

    public GameObject tofas_select;
    public GameObject honda_select;
    public GameObject subuwu_select;

    public GameObject honda_buy_but;
    public GameObject subuwu_buy_but;

    public Text cay_miktar;
    public void basla()
    {
        PlayerPrefs.SetInt("bannerdurum", 1);
        SceneManager.LoadScene("oyun");
    }
    public void shop()
    {
        shop_panel.SetActive(true);
    }
    public void menu_don()
    {
        shop_panel.SetActive(false);
    }
    public void sag_but()
    {
        sag_basma++;
        sol_button.SetActive(true);
        if (sag_basma == 1)
        {
            tofas.SetActive(false);
            honda.SetActive(true);
        }
        if (sag_basma == 2)
        {
            tofas.SetActive(false);
            honda.SetActive(false);
            subuwu.SetActive(true);
            sag_button.SetActive(false);
        }
         
    }
    public void sol_but()
    {
        sag_basma--;
        sag_button.SetActive(true);
        if (sag_basma == 0)
        {
            sol_button.SetActive(false);
            tofas.SetActive(true);
            honda.SetActive(false);
        }
        if (sag_basma == 1)
        {
            
            honda.SetActive(true);
            subuwu.SetActive(false);
            
        }
    }

    public void tofas_sec()
    {
        PlayerPrefs.SetInt("skin_id", 0);
        tofas_select.SetActive(false);
        honda_select.SetActive(true);
        subuwu_select.SetActive(true);
    }
    public void honda_sec()
    {
        PlayerPrefs.SetInt("skin_id", 1);
        tofas_select.SetActive(true);
        honda_select.SetActive(false);
        subuwu_select.SetActive(true);
    }
    public void subuwu_sec()
    {
        PlayerPrefs.SetInt("skin_id", 2);
        tofas_select.SetActive(true);
        honda_select.SetActive(true);
        subuwu_select.SetActive(false);

    }
    public void honda_buy()
    {
        if (PlayerPrefs.GetInt("cay_sayi")>=1000)
        {
            PlayerPrefs.SetInt("honda_al", 1);
            honda_buy_but.SetActive(false);
            PlayerPrefs.SetInt("cay_sayi", PlayerPrefs.GetInt("cay_sayi") - 1000);
            cay_miktar.text = "= " + PlayerPrefs.GetInt("cay_sayi").ToString();
        }
        
    }
    public void subuwu_buy()
    {
        if (PlayerPrefs.GetInt("cay_sayi") >= 1000)
        {
            PlayerPrefs.SetInt("subuwu_al", 1);
            subuwu_buy_but.SetActive(false);
            PlayerPrefs.SetInt("cay_sayi", PlayerPrefs.GetInt("cay_sayi") - 1000);
            cay_miktar.text = "= " + PlayerPrefs.GetInt("cay_sayi").ToString();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sol_button.SetActive(false);
        shop_panel.SetActive(false);
        honda.SetActive(false);
        subuwu.SetActive(false);
        
        if (PlayerPrefs.GetInt("skin_id")==0)
        {
            tofas_select.SetActive(false);
        }
        if (PlayerPrefs.GetInt("honda_al") == 1)
        {
            honda_buy_but.SetActive(false);
            if (PlayerPrefs.GetInt("skin_id") == 1)
        {
            
            
                honda_buy_but.SetActive(false);
                tofas_select.SetActive(true);
                honda_select.SetActive(false);
                subuwu_select.SetActive(true);
            
            
        }
        }
        if (PlayerPrefs.GetInt("subuwu_al") == 1)
        {
            subuwu_buy_but.SetActive(false);
            if (PlayerPrefs.GetInt("skin_id") == 2)
        {
            
            
                tofas_select.SetActive(true);
                honda_select.SetActive(true);
                subuwu_select.SetActive(false);
            
           
        }

        }

        cay_miktar.text = "= "+PlayerPrefs.GetInt("cay_sayi").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
