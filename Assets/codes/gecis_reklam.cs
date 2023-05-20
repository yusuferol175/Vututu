using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class gecis_reklam : MonoBehaviour
{
    private InterstitialAd reklamObjesi;
    public static GameObject gecis_obje;
    void Start()
    {
        gecis_obje = gameObject;


    }
    public void gecis_ad()
    {
        MobileAds.Initialize(reklamDurumu => { });
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
        reklamObjesi = new InterstitialAd("ca-app-pub-3940256099942544/1033173712");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();

        reklamObjesi.LoadAd(reklamIstegi);
        StartCoroutine(ReklamiGoster());
    }

    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;
        reklamObjesi.Show();
    }
    void OnDestroy()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
    }
}
