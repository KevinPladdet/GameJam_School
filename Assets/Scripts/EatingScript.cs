using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EatingScript : MonoBehaviour
{
    private const float MAX_HUNGER = 100f;

    public static float Hunger = MAX_HUNGER;

    private Image HungerBar;

    public GameObject Idle;
    public GameObject Eating;
    public GameObject WinImage;

    void Start()
    {
        Hunger = 0f;
        HungerBar = GetComponent<Image>();
        Idle.SetActive(true);
        Eating.SetActive(false);
    }

    void Update()
    {
        HungerBar.fillAmount = Hunger / MAX_HUNGER;

        if(Input.GetKey(KeyCode.Space))
        {
            if (Time.timeScale != 0f)
            {
                EatingAudioManager.PlayEatSound();
                Idle.SetActive(false);
                Eating.SetActive(true);
            }
            Hunger += 1.6f * Time.deltaTime;
            Mother.isEating = true;
        }
        else
        {
            if(Mother.isCaught == false)
            {
                EatingAudioManager.StopEatSound();
                Idle.SetActive(true);
                Eating.SetActive(false);
                Mother.isEating = false;
            }
            if (Mother.isCaught == true)
            {
                EatingAudioManager.StopEatSound();
                MomSoundManager.StopMomSound();
                DoorSoundManager.StopSound();
            }
        }

        if(Hunger >= 100)
        {
            WinImage.SetActive(true);
            Time.timeScale = 0f;

            if (Input.GetKeyDown(KeyCode.F))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Kevin Scene");
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.Quit();
            }
        }
    }
}
