using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeviyeKaydet : MonoBehaviour
{
    public bool Seviye1, Seviye2;
  
    private void Start()
    {
        
        if (Seviye1==true)
        {
            PlayerPrefs.SetInt("Seviye", 0);          
        }

        if (Seviye2 == true)
        {
            PlayerPrefs.SetInt("Seviye", 1);
            PlayerPrefs.SetInt("MaksimumSeviye", 2);
        }
    }
}
