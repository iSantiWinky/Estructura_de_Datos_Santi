using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject prefab2;

    public float spawnRate = 5f;
    float spawnNext = 0f;
    int toSpwan;

    void Update()
    {
        if (Time.time > spawnNext)
        {
            toSpwan = Random.Range(1, 2);
            Debug.Log(toSpwan);

            switch (toSpwan)
            {
                case 1:
                    Vector3 prefabPosition2 = new Vector3(Random.Range(-3.2f, -.5f), Random.Range(4.5f, -4.5f), 0f);
                    Instantiate(prefab2, prefabPosition2, Quaternion.identity);
                    break;
            }

            spawnNext = Time.time + spawnRate;
        }
    }


}
