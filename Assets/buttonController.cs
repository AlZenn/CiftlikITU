using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{

    public void gameExit()
    {
        Application.Quit();

    }

    public void gameFreeze()
    {
        Time.timeScale = 0f;
    }public void gameContunie()
    {
        Time.timeScale = 1f;
    }
}
