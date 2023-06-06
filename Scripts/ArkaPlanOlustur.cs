using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanOlustur : MonoBehaviour
{

    public GameObject[] ArkaPlanPrefab;
    public float yOlusturma = -5;
    public float ArkaPlanUzunluk = 1;
    public int ArkaPlanSayi = 10;
    public Transform Oyuncu;
    private float spawnInterval;
    public GameObject Bonus;
    public Transform cam;

    void Start()
    {

        for (int i = 0;  i< ArkaPlanSayi; i++)
        {
            SpawnTile(Random.Range(0, ArkaPlanPrefab.Length-1)); //Sahne ilk olu?tu?unda sahneyi dolduracak kadar arkaplan olu?tulur
        }


    }

    void Update()
    {
        if (Oyuncu.position.y> yOlusturma-(ArkaPlanSayi*ArkaPlanUzunluk)&&yOlusturma<ArkaPlanUzunluk*17)
        {
            SpawnTile(Random.Range(0, ArkaPlanPrefab.Length-1)); //Oyuncu ilerledikçe yeni arka planlar olu?turulur
       
        }
 
    }

    public void SpawnTile(int tileIndex)
    {
        int sonelement = ArkaPlanPrefab.Length - 1;

        if (yOlusturma > ArkaPlanUzunluk * 15)
        {
            Instantiate(ArkaPlanPrefab[sonelement], transform.up * yOlusturma, transform.rotation);
            
        }
        Instantiate(ArkaPlanPrefab[tileIndex], transform.up*yOlusturma, transform.rotation);
        SpawnBonus();
        yOlusturma += ArkaPlanUzunluk; 
       
    }

    public void SpawnBonus()
    {
        float spawnY = Random.Range
                 (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(Bonus, spawnPosition, Quaternion.identity);

    }
}
