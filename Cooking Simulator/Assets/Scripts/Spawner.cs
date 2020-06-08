using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1;

    public float spawnRate = 5f;
    float spawnNext = 0f;
    int toSpwan;

    void Update()
    {
        if(Time.time > spawnNext)
        {
            toSpwan = Random.Range(1, 2);
            Debug.Log(toSpwan);

            switch(toSpwan)
            {
                case 1:
                    Vector3 prefabPosition1 = new Vector3(Random.Range(3.5f, 8f), Random.Range(-4f, 2.3f), 0f);
                    Instantiate(prefab1, prefabPosition1, Quaternion.identity);
                        break;
            }

            spawnNext = Time.time + spawnRate;
        }
    }


}
