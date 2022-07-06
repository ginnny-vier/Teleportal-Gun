using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

public GameObject prefabBullet;

public Transform bulletOrigin;

public Transform player;



    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject newBullet = Instantiate(prefabBullet, bulletOrigin.position, bulletOrigin.rotation);

            newBullet.GetComponent<Bullet>().playerTransform = player ;


        }
    }
}
