using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemySc : MonoBehaviour
{
    public int health = 10;
    public GameObject kendisi2, yancisi2;
    public Slider HealthSlider;
    public Text timeText;
    public float Timevalue = 10f;
    public GameObject endpanel;
    private void Start()
    {
        kendisi2.SetActive(false);


    }

    private void endGame()
    {
        Time.timeScale = 0f;
        endpanel.SetActive(true);
        
    }

    private void Update()
    {
        HealthSlider.value = health;
        timeText.text = Timevalue.ToString("F");
            
        if (kendisi2.activeInHierarchy == true)
        {
            zamangeriye();
        }

        if (Timevalue<= 0f)
        {
            endGame();
        }
    }

    public void zamangeriye()
    {
        Timevalue = Timevalue - Time.deltaTime;

    }

    public void damageEnemy()
    {
        health--;
        

        Control();
    }


    void Control()
    {
        if (health <= 0)
        {
            kendisi2.SetActive(false);
            yancisi2.SetActive(false);
            health = 10;
            Timevalue = 10f;

        }
        
        
    }
}
