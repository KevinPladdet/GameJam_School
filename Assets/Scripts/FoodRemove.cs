using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRemove : MonoBehaviour
{

    public List<GameObject> foodObjects;

    
    public GameObject Turkey;

    void Start()
    {
        foodObjects = new List<GameObject>();
        foodObjects.Add(transform.GetChild(0).gameObject);
        foodObjects.Add(transform.GetChild(1).gameObject);
        foodObjects.Add(transform.GetChild(2).gameObject);
        foodObjects.Add(transform.GetChild(3).gameObject);
        foodObjects.Add(transform.GetChild(4).gameObject);
        foodObjects.Add(transform.GetChild(5).gameObject);
        foodObjects.Add(transform.GetChild(6).gameObject);
        foodObjects.Add(transform.GetChild(7).gameObject);

        for (int i = 0; i < foodObjects.Count; i++)
        {
            GameObject temp = foodObjects[i];
            int randomIndex = Random.Range(i, foodObjects.Count);
            foodObjects[i] = foodObjects[randomIndex];
            foodObjects[randomIndex] = temp;
        }
    }


    void Update()
    {
        if(EatingScript.Hunger >= 12.5f)
        {
            foodObjects[0].SetActive(false);
        }
        if (EatingScript.Hunger >= 25f)
        {
            foodObjects[1].SetActive(false);
        }
        if (EatingScript.Hunger >= 37.5f)
        {
            foodObjects[2].SetActive(false);
        }
        if (EatingScript.Hunger >= 50f)
        {
            foodObjects[3].SetActive(false);
        }
        if (EatingScript.Hunger >= 62.5f)
        {
            foodObjects[4].SetActive(false);
        }
        if (EatingScript.Hunger >= 75f)
        {
            foodObjects[5].SetActive(false);
        }
        if (EatingScript.Hunger >= 87.5f)
        {
            foodObjects[6].SetActive(false);
        }
        if (EatingScript.Hunger >= 100f)
        {
            foodObjects[7].SetActive(false);
        }
    }
}
