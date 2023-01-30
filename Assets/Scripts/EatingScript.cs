using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatingScript : MonoBehaviour
{
    private const float MAX_HUNGER = 100f;

    public float Hunger = MAX_HUNGER;

    private Image HungerBar;

    void Start()
    {
        HungerBar = GetComponent<Image>();
    }

    void Update()
    {
        HungerBar.fillAmount = Hunger / MAX_HUNGER;

        if(Input.GetKey(KeyCode.Space))
        {
            if (Time.timeScale != 0f)
            {
                EatingAudioManager.PlaySound();
            }
            Hunger += 2 * Time.deltaTime;
            Mother.isEating = true;
        }
        else
        {
            EatingAudioManager.StopSound();
            Mother.isEating = false;
        }
    }
}
