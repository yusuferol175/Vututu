using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benzin_tutucu : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="zemin")
        {
            Destroy(gameObject);
        }
    }
}
