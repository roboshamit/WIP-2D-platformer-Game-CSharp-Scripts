﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            //other.GetComponent<AudioSource>().Play();﻿
            FindObjectOfType<GameManager>().GiveHealth();
            //Instantiate (bloodParticleObject, transform.position, transform.rotation);
             Destroy(gameObject);
            //Bulletcount.scorevalue += 3;
        }


    }
}
