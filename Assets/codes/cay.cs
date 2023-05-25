using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cay : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="zemin")
        {
            transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
        }
        
    }
}
