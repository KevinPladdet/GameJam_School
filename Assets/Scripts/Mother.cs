using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public static bool isEating;

    public GameObject DoorClosed;
    public GameObject DoorWarning;
    public GameObject DoorOpen;

    bool StartRandom = true;
    bool isLooking = false;
    public static bool isCaught = false;

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
        DoorClosed.SetActive(false);
        DoorWarning.SetActive(true);
        Debug.Log("Mother appeared");
        yield return new WaitForSeconds(Random.Range(0.45f, 1));
        DoorWarning.SetActive(false);
        DoorOpen.SetActive(true);
        isLooking = true;
        yield return new WaitForSeconds(Random.Range(1, 2));
        DoorOpen.SetActive(false);
        DoorClosed.SetActive(true);
        isLooking = false;
        StartRandom = true;
    }
}
