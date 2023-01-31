using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public static bool isEating;

    public GameObject DoorClosed;
    public GameObject DoorWarning;
    public GameObject DoorOpen;

    public static bool Peeking;
    public static bool Entering;
    public static bool Leaving;

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
        Peeking = true;
        DoorClosed.SetActive(false);
        DoorWarning.SetActive(true);
        Debug.Log("Mother appeared");
        yield return new WaitForSeconds(Random.Range(0.4f, 0.7f));
        Peeking = false;
        Entering = true;
        DoorWarning.SetActive(false);
        DoorOpen.SetActive(true);
        MomSoundManager.PlayMomSound();
        isLooking = true;
        yield return new WaitForSeconds(Random.Range(2, 3));
        DoorSoundManager.StopSound();
        Entering = false;
        Leaving = true;
        DoorOpen.SetActive(false);
        DoorClosed.SetActive(true);
        MomSoundManager.StopMomSound();
        isLooking = false;
        yield return new WaitForSeconds(0.2f);
        Leaving = false;
        DoorSoundManager.StopSound();
        StartRandom = true;
    }
}
