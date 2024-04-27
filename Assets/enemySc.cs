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

    private void Start()
    {
        kendisi2.SetActive(false);
        

    }

    private void Update()
    {
        HealthSlider.value = health;
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
        }
        
        
    }
}
