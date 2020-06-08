using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float spawnNext = 0f;
    public float spawnRate = 6f;

    [SerializeField]
    public GameObject client;
    public GameObject client2;
    public GameObject client3;

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

        /*bool clientSpawned = false;
        while(!clientSpawned)
        {
            Vector3 clientPosition = new Vector3(Random.Range(-3f, -.5f), Random.Range(-4f, 4f), 0f);
            if((clientPosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(client, clientPosition, Quaternion.identity);
                clientSpawned = true;
            }
        }*/

        bool client2Spawned = false;
        while (!client2Spawned)
        {
            Vector3 client2Position = new Vector3(Random.Range(3.5f, 8f), Random.Range(-4f, 2f), 0f);
            if(Time.time > spawnNext)
            {
                if ((client2Position - transform.position).magnitude < 3)
                {
                    continue;
                }
                else
                {
                    Instantiate(client2, client2Position, Quaternion.identity);
                    client2Spawned = true;
                }

                spawnNext = Time.time + spawnRate;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SpawnClient();

    }

    /*public void OnTriggerStay2D(Collider2D cocinaStay)
    {
        if (cocinaStay.gameObject.tag == "Cocina")
        {
            Debug.Log("Estas en la cocina, ¡TRABAJA!");
        }
    }*/
}
