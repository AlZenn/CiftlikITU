using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class destorysc : MonoBehaviour
{
    public int score;

    public Text ScoreText;

    public GameObject start, end;
    
    // Start is called before the first frame update
    private void Awake()
    {
        score = 0;
    }

    void Start()
    {
        Time.timeScale = 0f;
        start.SetActive(true);
        end.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score.ToString();

        
    }

    public void startGame()
    {
        Time.timeScale = 1f;
        start.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "a"&& this.gameObject.GetComponent<SpriteRenderer>().sprite.name =="a")
        {
            score++;
            Destroy(other.gameObject);
        }
        
        else if (other.gameObject.tag == "k"&& this.gameObject.GetComponent<SpriteRenderer>().sprite.name =="k")
        {
            score++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "i"&& this.gameObject.GetComponent<SpriteRenderer>().sprite.name =="i")
        {
            score++;
            Destroy(other.gameObject);
        }
        else
        {
                Destroy(other.gameObject);
                Time.timeScale = 0f;
                end.SetActive(true);
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
