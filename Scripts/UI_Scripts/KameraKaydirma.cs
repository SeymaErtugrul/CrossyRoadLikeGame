using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KameraKaydirma : MonoBehaviour
{
    public Rigidbody2D _rb;
    float hiz = 2f;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {

        _rb.velocity = Vector2.right * hiz;

    }

    public int SahneNumara(int sahneno)
    {

        return sahneno;
    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.CompareTag("Sinir"))
        {
            if (PlayerPrefs.GetInt("Seviye",0)==0)
            {
                SceneManager.LoadScene(2);
            }


            if (PlayerPrefs.GetInt("Seviye", 1) == 1)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
