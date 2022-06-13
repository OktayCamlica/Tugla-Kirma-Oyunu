using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    int puan;
    public void PuanArtir()
    {
        puan++;
    }
    public int PuaniAl()
    {
        return puan;
    }
    public void PuanSifirla()
    {
        puan = 0;
    }
}
