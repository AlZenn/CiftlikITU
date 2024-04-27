using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] obje;
    // Start is called before the first frame update
    public GameObject enemy, yancisi;
    void Start()
    {
        Clone();
        InvokeRepeating("CloneEnemy",10f,10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clone()
    {
        Instantiate(obje[Random.Range(0, obje.Length)], this.gameObject.transform.position, Quaternion.identity);
        Invoke("Clone",2f);

    }

    public void CloneEnemy()
    {
        enemy.SetActive(true);
        yancisi.SetActive(true);
        
    }

}
