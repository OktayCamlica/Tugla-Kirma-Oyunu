using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puan;
    void Start()
    {
        puan.text = "PUANINIZ : " + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuaniAl(); 
    }

  public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
   
}
