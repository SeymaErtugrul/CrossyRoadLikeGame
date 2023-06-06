using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YenidenBaslat : MonoBehaviour
{
    public void SahneYukle()
    {   
        SceneManager.LoadScene(1);
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
