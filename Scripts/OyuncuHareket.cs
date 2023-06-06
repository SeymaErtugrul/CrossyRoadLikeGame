using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OyuncuHareket : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector3 Dokunusilk;
    private Vector3 Dokunusson;
    private int aralik = 1;
    public GameObject panel;
    public GameObject zamanbitti;
    private void Start()
    {
        panel.SetActive(false);
  
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchpos = Camera.main.ScreenToWorldPoint(touch.position);//Ekran pozisyonunu oyun pozisyonuna çevirmek için

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Dokunusilk = touchpos;
                    break;

                case TouchPhase.Moved:

                    rb.velocity = Vector2.zero;
                    break;

                case TouchPhase.Ended:
                    Dokunusson = touchpos;
                    if (Mathf.Abs(Dokunusson.x - Dokunusilk.x) > aralik && Mathf.Abs(Dokunusson.y - Dokunusilk.y) > aralik) //ÇAPRAZ İHTİMALİNE KARŞI
                        break;

                    if ((Dokunusson.x - Dokunusilk.x) > aralik)//sağ
                        rb.transform.position += new Vector3(0.3f, 0, 0);

                    else if ((Dokunusilk.x - Dokunusson.x) > aralik)//sol
                        rb.transform.position += new Vector3(-0.3f, 0, 0);

                    else if ((Dokunusilk.y - Dokunusson.y) > aralik)//aşağı
                        rb.transform.position += new Vector3(0, -0.3f, 0);
                    else//yukarı
                        rb.transform.position += new Vector3(0, 0.3f, 0);//sadece dokunulduğu zaman da yukarı gitmesi için else 
                    break;
            }

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("cisim"))
        {
            zamanbitti.SetActive(false);
            panel.SetActive(true);
            Time.timeScale = 0;
        }

    }
}


