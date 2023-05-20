using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teker_sc : MonoBehaviour
{
    public Image yakit_resmi;
    public float artan_yakit;

    public GameObject benzin_ses;
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
