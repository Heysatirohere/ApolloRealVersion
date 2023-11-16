using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideHouse2 : MonoBehaviour
{
    public LoadManager Manager;
    private void OnCollisionEnter(Collision Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            Manager.Load("InHouse2");
        }
    }

}
