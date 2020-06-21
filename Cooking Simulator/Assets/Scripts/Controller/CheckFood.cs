using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFood : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Client")
        {
            Destroy(this.gameObject);
            Destroy(this.gameObject);
        }
    }
}
