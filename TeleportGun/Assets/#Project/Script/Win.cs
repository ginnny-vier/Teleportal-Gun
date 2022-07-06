using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ah");
        if(other.tag == "Player")
        {
            Debug.Log("Win");
        }
    }
}
