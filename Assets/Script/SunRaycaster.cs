using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRaycaster : MonoBehaviour
{
    public Transform player;
    public Transform sun;
    public bool isPlayerLit;

    void Update()
    {
        Vector3 direction = player.position - sun.position;
        RaycastHit hit;

        if (Physics.Raycast(sun.position, direction, out hit))
        {
            if (hit.transform == player)
            {
                isPlayerLit = true;
            }
            else
            {
                isPlayerLit = false;
            }

        }
        Debug.DrawRay(sun.position, direction * 1000, Color.green);
    }
}