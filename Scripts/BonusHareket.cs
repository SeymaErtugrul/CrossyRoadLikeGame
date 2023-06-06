using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BonusHareket : MonoBehaviour
{
    public Vector2 hareket;
    public int Donus = 2; //Sahnenin biti? s?n?r?
    public int Baslangic = -3; //Sahnenin ba?lang?ç s?n?r?
    public float hiz = 0.01f;

    private void Update()
    {
        transform.position += transform.right * hiz; //Objeyi x boyunca hareket ettirmek için kullan?l?r

        if (transform.position.x > Donus)   // Obje sahneden ç?kt?ysa ba?a döndürülür
        {
            hareket.x = Baslangic;
            hareket.y = transform.position.y;

            transform.position = hareket;

        }
    }
}