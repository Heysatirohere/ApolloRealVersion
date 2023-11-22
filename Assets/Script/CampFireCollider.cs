using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFireCollider : MonoBehaviour
{
    public itemManager Stick;
    public LoadManager LoadManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && Stick.item >= 10)
        {
            LoadManager.Load("End"); 
        }
    }
}
