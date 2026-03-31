using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible2D : MonoBehaviour
{

    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0,3, rotationSpeed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //destroy the collectible
        Destroy(gameObject);


        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }
    
}