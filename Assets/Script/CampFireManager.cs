using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CampfireManager : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            itemManager.instance.item++;
            Destroy(gameObject);

        }




    }


}
