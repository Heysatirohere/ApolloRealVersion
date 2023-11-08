using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ColetavelManager : MonoBehaviour
{
    public int item = 1; 
    public static ColetavelManager instance;
    public Text CountItem;

    void Awake()
    {
        
       instance = this;

    }

    // Update is called once per frame
    void Update()
    {

        CountItem.text = "Key: " + item.ToString() + "/1";
    
    }
  }
