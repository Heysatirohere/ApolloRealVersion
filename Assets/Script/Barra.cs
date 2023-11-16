using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public LoadManager LoadManager;
    public Image barra;
    float timeBarra = 90; 


    void Update()
    {
        if (timeBarra <= 0)
        {
            LoadManager.Load("Die");
        }
        timeBarra -= Time.deltaTime;
        barra.fillAmount = timeBarra / 90;
    }
}
