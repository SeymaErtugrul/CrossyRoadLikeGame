using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GirisMenu : MonoBehaviour
{
    public GameObject[] liste;
    public GameObject button;
    void Update()
    {
        SkorGoster();
    }

    void SkorGoster()
    {
        if (PlayerPrefs.GetInt("MaksimumSeviye")!=2)
        {
            Butonetkisiz();
            if (50<PlayerPrefs.GetInt("YüksekPuan1")&& 100>PlayerPrefs.GetInt("YüksekPuan1"))
            {
                liste[0].SetActive(false);
            }
            else if(100<PlayerPrefs.GetInt("YüksekPuan1")&& PlayerPrefs.GetInt("YüksekPuan1")<150)
            {
                liste[0].SetActive(false);
                liste[1].SetActive(false);
            }
            else 
            {
                liste[0].SetActive(false);
                liste[1].SetActive(false);
                liste[2].SetActive(false);
            }   
        }   
    }

    public void Butonetkisiz()
    {
        button.GetComponent<Button>().interactable = false;

    }
}
