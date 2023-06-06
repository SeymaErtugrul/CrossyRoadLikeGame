using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BonusHareket : MonoBehaviour
{
    public Vector2 hareket;
    public int Donus = 2; //Sahnenin biti? s?n?r?
    public int Baslangic = -3; //Sahnenin ba?lang?� s?n?r?
    public float hiz = 0.01f;

    private void Update()
    {
        transform.position += transform.right * hiz; //Objeyi x boyunca hareket ettirmek i�in kullan?l?r

        if (transform.position.x > Donus)   // Obje sahneden �?kt?ysa ba?a d�nd�r�l�r
        {
            hareket.x = Baslangic;
            hareket.y = transform.position.y;

            transform.position = hareket;

        }
    }
}