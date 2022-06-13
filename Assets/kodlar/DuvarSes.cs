using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarSes : MonoBehaviour
{

    public AudioClip sesEfekt;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(sesEfekt, transform.position);
    }


}
