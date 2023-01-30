using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public static bool isEating;

    public GameObject Door;
    bool StartRandom = true;
    bool isLooking = false;
    bool isCaught = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(StartRandom)
        {
            StartCoroutine(MotherComes());
        }

        if (Input.GetKey(KeyCode.Space) && isLooking && !isCaught)
        {
            Debug.Log("You got caught!");
            isCaught = true;
            Time.timeScale = 0f;
            //open up defeat screen
        }
    }

    IEnumerator MotherComes()
    {
        StartRandom = false;
        yield return new WaitForSeconds(Random.Range(3, 12));
        Door.SetActive(false);
        Debug.Log("Mother appeared");
        yield return new WaitForSeconds(1);
        isLooking = true;
        yield return new WaitForSeconds(Random.Range(1, 2));
        Door.SetActive(true);
        isLooking = false;
        StartRandom = true;
    }
}
