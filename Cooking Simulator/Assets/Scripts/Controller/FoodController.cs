using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public GameObject hamburguer;
    public GameObject pizza;
    public GameObject objectDad;
    Vector3 spawn;

    public void HamburguerInsta()
    {
        spawn = transform.position + new Vector3(-0.2f, 0, 0);
        GameObject hamburguerComplete = Instantiate(hamburguer, spawn, Quaternion.identity) as GameObject;
        hamburguerComplete.transform.parent = objectDad.transform;
        hamburguerComplete.transform.position = spawn;
    }

    public void PizzaInsta()
    {
        spawn = transform.position + new Vector3(.6f, 0, 0);
        GameObject pizzaComplete = Instantiate(pizza, spawn, Quaternion.identity) as GameObject;
        pizzaComplete.transform.parent = objectDad.transform;
        pizzaComplete.transform.position = spawn;
    }
}
