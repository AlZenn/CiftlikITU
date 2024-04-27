using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objeTrigger : MonoBehaviour
{
    public GameObject kendisi;
    void Start()
    {
        kendisi.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "a")
        {
            Destroy(other.gameObject);
        }
        
        else if (other.gameObject.tag == "k")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "i")
        {
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
