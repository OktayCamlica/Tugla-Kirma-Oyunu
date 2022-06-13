using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    public AudioClip sesEfekt;
    GameObject top;
    void Start()
    {
        top = GameObject.Find("top");
    }

   
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        // transform.position = new Vector3(Mathf.Clamp( farePos.x, -2.97f , 2.90f) ,  transform.position.y, transform.position.z);
         transform.position = new Vector3(top.transform.position.x, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(sesEfekt, transform.position);
    }
}
