using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
Rigidbody rb;
public float force;
public float x;

public Transform playerTransform;

    void Start()
    {
        //------- cherche le compo du rigidbody et lui ajoute une force vers le haut (up)
        rb =  GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force); 

    }

    //----FixedUpdate 60FPS d'office . A UTILISER LORS CE QU'ON UTILISE LA PHYSIQUE---- //
    //void FixedUpdate()

    void OnCollisionEnter(Collision collision)
    {
        playerTransform.position = collision.GetContact(0).point;
        Destroy(gameObject);

    }

}
