using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public Sprite[] barinaklar;
    public SpriteRenderer image;
    public string isim;
    public Button buton;
    void Start()
    {
        image = GameObject.FindWithTag("imageBarinak").GetComponent<SpriteRenderer>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (image != null)
        {
            image = GameObject.FindWithTag("imageBarinak").GetComponent<SpriteRenderer>();
            isim = image.sprite.name;
        }
    }

    public void Clicker()
    {
        if (isim == "k")
        {
            image.sprite = barinaklar[0];
        }else if (isim == "a")
        {
            image.sprite = barinaklar[1];
        }else if (isim == "i")
        {
            image.sprite = barinaklar[2];
        }
        
        
    }
}
