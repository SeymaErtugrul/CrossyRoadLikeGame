using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class PuanHesapla : MonoBehaviour
{
    public int puan;
    public TextMeshProUGUI Skor;
    int y�ksekpuan1, y�ksekpuan2;
    int Seviye;
    void Start()
    {
        Skor.text = puan.ToString();
        y�ksekpuan1 = PlayerPrefs.GetInt("YuksekPuan1");
        y�ksekpuan2 = PlayerPrefs.GetInt("YuksekPuan2");
        Seviye = PlayerPrefs.GetInt("Seviye");
        puan = 0;
    }

    
    void Update()
    {
        Skor.text = puan.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bonus"))
        {

            puan += 10;

        }

        if (collision.gameObject.CompareTag("son"))
        {
            puan += 50;
            PlayerPrefs.SetInt("Skor", puan);
            if (puan>y�ksekpuan1 && Seviye==1)
            {
                PlayerPrefs.SetInt("YuksekPuan1", puan);
            }
            else if(puan>y�ksekpuan2 && Seviye==2)
            {
                PlayerPrefs.SetInt("YuksekPuan2", puan);
            }
            
            SceneManager.LoadScene(4);
            puan = 0;

        }

    }
}
