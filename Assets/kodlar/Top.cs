using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    GameObject pedal;
    bool oyunBasladi = false;
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
       
    }

   
    void Update()
    {
        if (!oyunBasladi)
        {
            transform.position = new Vector3(pedal.transform.position.x, pedal.transform.position.y + .15f, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) && !oyunBasladi)
        {
            oyunBasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 9f);
        }

    }
}
