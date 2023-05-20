using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sii : MonoBehaviour
{
    public GameObject olum_panel;
    public bool silis_drm = false;
    public void silis_zamani()
    {
        silis_drm = true;
    }

    private void OnTriggerEnter2D(Collider2D yumusak)
    {
        if (yumusak.gameObject.tag=="araba")
        {
            olum_panel.gameObject.SetActive(true);
        }
        Destroy(yumusak.gameObject);
        
    }
    

    void Start()
    {

        Invoke("silis_zamani", 40f);
    }

    // Update is called once per frame
    void Update()
    {
        if (silis_drm)
        {
            transform.position += new Vector3(5f * Time.deltaTime, 0, 0);
        }
    }
}
