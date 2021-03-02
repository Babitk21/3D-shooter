﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletReference=Instantiate(bullet);
            bulletReference.transform.position = transform.position;
            Rigidbody rb = bulletReference.GetComponent<Rigidbody>();
            rb.velocity =transform.rotation*Vector3.forward * 100.0f;
            
        }
    }
}
