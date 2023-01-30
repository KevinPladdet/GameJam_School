using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public static bool isEating;

    public GameObject Door;
    bool StartRandom = true;

    void Start()
    {
        
    }

    void Update()
    {
        if(StartRandom == true)
        {
            StartCoroutine(MotherComes());
        }
    }

    IEnumerator MotherComes()
    {
        Debug.Log("Mother can appear now");
        yield return new WaitForSeconds(Random.Range(5, 15));
        Door.SetActive(false);
        Debug.Log("Mother appeared");
        yield return new WaitForSeconds(1);
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("You got caught!");
            //open up defeat screen
        }
        yield return new WaitForSeconds(4);
        Door.SetActive(true);
        StartRandom = false;
        yield return new WaitForSeconds(1);
        StartRandom = true;

    }
}
