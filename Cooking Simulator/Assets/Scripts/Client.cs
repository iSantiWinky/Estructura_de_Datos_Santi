using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hamburguesa")
        {
            ScoreManager.clientScore += 5;
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Pizza")
        {
            ScoreManager.clientScore -= 10;
            Destroy(gameObject);
        }
    }
}
