using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 

public class BarraVida : MonoBehaviour
{
    public float Life = 20;
    public Image LifeBar;
    public SunRaycaster src; 
    public LoadManager Lm; 
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if(src.isPlayerLit)
        {
            Life -= Time.deltaTime * 3;
        }
        else
        {
            Life += Time.deltaTime;
            Life = Mathf.Clamp(Life, 0, 20);
        }
        LifeBar.fillAmount = Life / 20;

        if (Life <= 0)
        {
            Lm.Load("Die2");
        }  
            
     
    }
}
