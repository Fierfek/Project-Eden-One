using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportTile : MonoBehaviour
{
    public Transform target = null;
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = target.position;
        }

    }

}
