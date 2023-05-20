using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class araba : MonoBehaviour
{
    public GameObject arabaa;
    public WheelJoint2D arka_teker;
    public WheelJoint2D on_teker;

    public float hiz;
    private float hareket;
    public float v;

    public Image yakit_resmi;
    public float toplam_yakit = 560;
    public float yakit_azalama_hiz;
    public float artan_yakit;

    public Text cay_miktar_text;
    public int cay_miktar;

    public GameObject olum_panel;
    bool benzin_durumu=true;

    public int guncel_konum;
    public Text oyun_metre;
    public int sonkonum;

    public Text olum_metre;

    public GameObject kafa;
    public Sprite subuwu;
    public Sprite honda;

    public GameObject motor_ses;
    public GameObject cay_ses;
    public GameObject benzin_ses;
    public GameObject olum_ses;
    public GameObject arkaplan_ses;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "benzin")
        {
            Destroy(collision.gameObject);
            benzin_ses.GetComponent<AudioSource>().Play();
            RectTransform asd = yakit_resmi.GetComponent<RectTransform>();
            asd.sizeDelta = new Vector2(artan_yakit, asd.sizeDelta.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="cay")
        {
            Destroy(collision.gameObject);
            cay_miktar = PlayerPrefs.GetInt("cay_sayi") + 1;
            PlayerPrefs.SetInt("cay_sayi", cay_miktar);
            cay_miktar_text.text = PlayerPrefs.GetInt("cay_sayi").ToString();

            cay_ses.GetComponent<AudioSource>().Play();
        }
        //if (collision.gameObject.tag=="benzin")
        //{
        //    Destroy(collision.gameObject);
        //    RectTransform asd = yakit_resmi.GetComponent<RectTransform>();
        //    asd.sizeDelta = new Vector2(artan_yakit, asd.sizeDelta.y);
        //}
        if (collision.gameObject.tag=="map_art")
        {
            Destroy(collision.gameObject);
            sonsuz_map.sonsuz_mp.GetComponent<sonsuz_map>().map_cogalt();

        }
    }

    public void gaz()
    {
        v = 1;

    }
    public void fren()
    {
        v = -1;

    }
    public void cekildi()
    {
        v = 0;
    }
    void Start()
    {
        
        if (PlayerPrefs.GetInt("skin_id") == 1)
        {
            arabaa.GetComponent<SpriteRenderer>().sprite = honda;
            on_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor = new Vector3(on_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.x - 0.8f, on_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.y);
            arka_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor = new Vector3(arka_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.x - 0.8f, arka_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.y);
        }
        if (PlayerPrefs.GetInt("skin_id")==2)
        {
            arabaa.GetComponent<SpriteRenderer>().sprite = subuwu;
            kafa.gameObject.transform.position = new Vector3(kafa.transform.position.x - 0.4f, kafa.transform.position.y);

            on_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor = new Vector3(on_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.x - 1.2f, on_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.y);
            arka_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor = new Vector3(arka_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.x - 1.2f, arka_teker.gameObject.GetComponent<WheelJoint2D>().connectedAnchor.y);
        }
       


        cay_miktar_text.text = PlayerPrefs.GetInt("cay_sayi").ToString();
    }

    
    void Update()
    {
        guncel_konum = (int)gameObject.transform.position.x;
        oyun_metre.text = guncel_konum.ToString() + "M";

        //float v= Input.GetAxis("Horizontal");
        hareket = hiz * v;
        RectTransform asd = yakit_resmi.GetComponent<RectTransform>();
        if (asd.sizeDelta.x < 0)
        {

            if (benzin_durumu)
            {

                PlayerPrefs.SetInt("olum_sayi", PlayerPrefs.GetInt("olum_sayi") + 1);
                if (PlayerPrefs.GetInt("olum_sayi") == 2 || PlayerPrefs.GetInt("olum_sayi") == 4 || PlayerPrefs.GetInt("olum_sayi") == 6)
                {
                    gecis_reklam.gecis_obje.GetComponent<gecis_reklam>().gecis_ad();
                    
                }

                motor_ses.GetComponent<AudioSource>().Stop();
                arkaplan_ses.GetComponent<AudioSource>().Stop();
                olum_ses.GetComponent<AudioSource>().Play();
                sonkonum = (int)gameObject.transform.position.x;
                olum_metre.text = sonkonum.ToString() + "M";
                Time.timeScale = 0f;
                olum_panel.SetActive(true);
                benzin_durumu = false;
            }

        }
        if (asd.sizeDelta.x > 0)
        {
            asd.sizeDelta = new Vector2(asd.sizeDelta.x - Time.deltaTime * yakit_azalama_hiz, asd.sizeDelta.y);
        }


        

    }
    bool ses_durum = true;
    void FixedUpdate()
    {
        if (hareket==0)
        {
            
            
            arka_teker.useMotor = false;
            on_teker.useMotor = false;
        }
        else
        {
            
            if (ses_durum)
            {
                motor_ses.GetComponent<AudioSource>().Play();
                ses_durum = false;
            }
            
            arka_teker.useMotor = true;
            on_teker.useMotor = true;
            JointMotor2D motore = new JointMotor2D();
            motore.motorSpeed = hareket;
            motore.maxMotorTorque = 10000;
            arka_teker.motor = motore;
            on_teker.motor = motore;
        }
        
    }

    
}
