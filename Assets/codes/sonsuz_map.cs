using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sonsuz_map : MonoBehaviour
{
    public static GameObject sonsuz_mp;

    public GameObject benzin;
    public GameObject benzin_pos;
    float benzin_m;

    public GameObject benzin_tutan;
    public GameObject benzin__tutan_pos;

    public GameObject cay;
    public GameObject cay_pos;
    float cay_m;

    public GameObject zemin;
    public GameObject zemin_pos;
    float zemin_m;

    public GameObject arkaplan;
    public GameObject arkaplan_pos;
    float arkaplan_m;

    public GameObject map_olus;
    public GameObject map_olus_pos;
    float map_arttir_pos;
    
    public void map_cogalt()
    {
        Instantiate(map_olus, new Vector3(map_olus_pos.transform.position.x + map_arttir_pos, map_olus_pos.transform.position.y, 0f), map_olus_pos.transform.rotation);
        map_arttir_pos += 400f;
        for (int i = 0; i < 4; i++)
        {
            int zemin_id = Random.Range(0,10);
            
            Instantiate(zeminler[zemin_id], new Vector3(zemin_pos.transform.position.x + zemin_m, zemin_pos.transform.position.y, 0f), zemin.transform.rotation);
            zemin_m += 129.8f;
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(benzin, new Vector3(benzin_pos.transform.position.x + benzin_m, benzin_pos.transform.position.y, 0f), benzin_pos.transform.rotation);

            Instantiate(benzin_tutan, new Vector3(benzin__tutan_pos.transform.position.x + benzin_m, benzin__tutan_pos.transform.position.y, 0f), benzin__tutan_pos.transform.rotation);

            Instantiate(arkaplan, new Vector3(arkaplan_pos.transform.position.x + arkaplan_m, arkaplan_pos.transform.position.y, 0f), arkaplan.transform.rotation);
            arkaplan.transform.localScale = new Vector3(arkaplan.transform.localScale.x * -1, arkaplan.transform.localScale.y, arkaplan.transform.localScale.x);

            Instantiate(cay, new Vector3(cay_pos.transform.position.x + cay_m, cay_pos.transform.position.y, 0f), cay.transform.rotation);



            benzin_m += 160f;
            arkaplan_m += 45f;
            cay_m += 45f;
            


        }
    }
    public List<GameObject> zeminler = new List<GameObject>();
    void Start()
    {
        
        sonsuz_mp = gameObject;

        Instantiate(map_olus, new Vector3(map_olus_pos.transform.position.x + map_arttir_pos, map_olus_pos.transform.position.y, 0f), map_olus_pos.transform.rotation);
        map_arttir_pos += 350f;
        for (int i = 0; i < 4; i++)
        {
            int zemin_id = Random.Range(0,10);
            
            Instantiate(zeminler[zemin_id], new Vector3(zemin_pos.transform.position.x + zemin_m, zemin_pos.transform.position.y, 0f), zemin.transform.rotation);
            zemin_m += 129.8f;
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(benzin, new Vector3(benzin_pos.transform.position.x + benzin_m, benzin_pos.transform.position.y, 0f), benzin_pos.transform.rotation);

            Instantiate(benzin_tutan, new Vector3(benzin__tutan_pos.transform.position.x + benzin_m, benzin__tutan_pos.transform.position.y, 0f), benzin__tutan_pos.transform.rotation);


            Instantiate(arkaplan, new Vector3(arkaplan_pos.transform.position.x+ arkaplan_m, arkaplan_pos.transform.position.y, 0f), arkaplan.transform.rotation);
            arkaplan.transform.localScale = new Vector3(arkaplan.transform.localScale.x * -1, arkaplan.transform.localScale.y, arkaplan.transform.localScale.x);

            Instantiate(cay, new Vector3(cay_pos.transform.position.x + cay_m, cay_pos.transform.position.y, 0f), cay.transform.rotation);

            

            benzin_m += 160f;
            arkaplan_m += 45f;
            cay_m += 45f;
            

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
