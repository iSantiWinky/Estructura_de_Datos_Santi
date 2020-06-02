using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4;

    public float spawnRate = 5f;
    float spawnNext = 0f;
    int toSpwan;

    void Update()
    {
        if(Time.time > spawnNext)
        {
            toSpwan = Random.Range(1, 5);
            Debug.Log(toSpwan);

            switch(toSpwan)
            {
                case 1:
                    Instantiate(prefab1, transform.localPosition, Quaternion.identity);
                        break;
                case 2:
                    Instantiate(prefab2, transform.localPosition, Quaternion.identity);
                        break;
                case 3:
                    Instantiate(prefab3, transform.localPosition, Quaternion.identity);
                        break;
                case 4:
                    Instantiate(prefab4, transform.localPosition, Quaternion.identity);
                        break;

            }

            spawnNext = Time.time + spawnRate;
        }
    }


}
