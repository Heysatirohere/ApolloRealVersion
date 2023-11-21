using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    public ColetavelManager key;
    public LoadManager manager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && key.item == 1)
        {
            manager.Load("Phase2");
        }
    }
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
