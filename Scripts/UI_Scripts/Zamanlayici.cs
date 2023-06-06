using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Zamanlayici : MonoBehaviour
{
    Image Doldurma;
    public float ZamanMaksimum;
    float ZamanKalan;
    public GameObject Panel;
    public GameObject carpma;
    void Start()
    {
        Panel.SetActive(false);
        Doldurma=GetComponent<Image>();
        ZamanKalan = ZamanMaksimum;
    }

    void Update()
    {
        if (ZamanKalan>0)
        {
            ZamanKalan -= Time.deltaTime;
            Doldurma.fillAmount = ZamanKalan / ZamanMaksimum;
        }

        else
        {
            Time.timeScale = 0;
            carpma.SetActive(false);
            Panel.SetActive(true);           
        }
    }
}
