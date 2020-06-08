using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed;

    [SerializeField]
    public GameObject client;

    private void Start()
    {
        player.GetComponent<GameObject>();
        SpawnClient();
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

    private void SpawnClient()
    {
        bool clientSpawned = false;
        while(!clientSpawned)
        {
                Vector3 clientPosition = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0f);
                if ((clientPosition - transform.position).magnitude < 3)
                {
                    continue;
                }
                else
                {
                    Instantiate(client, clientPosition, Quaternion.identity);
                    clientSpawned = true;
                }
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SpawnClient();
    }
}
