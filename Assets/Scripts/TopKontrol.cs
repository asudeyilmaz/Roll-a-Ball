using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz;
    public int puan;
    public int objeSayisi;
    public Text puanText;
    public Text oyunBittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vektor * hiz);


    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;
        puanText.text = "Puan : " + puan;

        if (puan == objeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    }


}
