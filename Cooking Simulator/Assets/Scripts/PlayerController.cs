using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
   
    public GameObject player;
    public float speed;

    private void Start()
    {
        player.GetComponent<GameObject>(); 
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            player.transform.position = new Vector3(player.transform.position.x - speed, player.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - speed, 0);
        }

    }

}
