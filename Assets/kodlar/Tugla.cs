using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public GameObject kirilmaEfekt;
    public static int toplamTuglaSayisi;
    public Sprite[] tuglaSprite;
    int maxCarpmaSayisi;
    int carpmaSayisi;
    Puan puanScript;
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        puanScript = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

   
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("top"))
        {
            puanScript.PuanArtir();
            carpmaSayisi++;
            if (carpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                if (toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
                Vector3 pos = collision.contacts[0].point;
                GameObject go = Instantiate(kirilmaEfekt, pos, Quaternion.identity) as GameObject;
                Color tuglaRengi = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = tuglaRengi;
                Destroy(go, 1f);
                Destroy(gameObject);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];

            }

        }
    }
}
