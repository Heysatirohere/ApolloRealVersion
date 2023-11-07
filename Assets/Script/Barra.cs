using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public Image barra;
    float timeBarra = 90; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeBarra -= Time.deltaTime;
        barra.fillAmount = timeBarra / 90;
    }
}
