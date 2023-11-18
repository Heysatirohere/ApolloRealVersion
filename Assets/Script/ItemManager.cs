using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class itemManager : MonoBehaviour
{
    public int item = 0;
    public static itemManager instance;
    public Text CountItem;

    void Awake()
    {

        instance = this;


    }

    // Update is called once per frame
    void Update()
    {

        CountItem.text = "Gravetos: " + item.ToString() + " /10";

    }
}
