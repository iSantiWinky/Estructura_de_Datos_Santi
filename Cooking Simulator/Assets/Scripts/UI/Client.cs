using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            LifeManager.lives -= 1;

            if(LifeManager.lives == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
