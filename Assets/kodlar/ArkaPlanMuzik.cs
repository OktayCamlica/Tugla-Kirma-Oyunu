using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanMuzik : MonoBehaviour
{
    static bool sahnedeMuzikVar;
    void Start()
    {
        if (!sahnedeMuzikVar)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            sahnedeMuzikVar = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }



   
    void Update()
    {
        
    }
}
