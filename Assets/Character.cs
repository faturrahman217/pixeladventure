using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int kecepatan, kekuatanLompat;

    public int pindah;
    public bool balik;

    public bool tanah;
    public LayerMask targetLayer;
    public Transform deteksiTanah;
    public float jangkauan;

    Rigidbody2D lompat;

    void Start()
    {
        lompat = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        tanah = Physics2D.OverlapCircle(deteksiTanah.position, jangkauan, targetLayer);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = -1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
            pindah = 1;
        }

        if (tanah == true && (Input.GetKey(KeyCode.W)))
        {
            lompat.AddForce(new Vector2(0, kekuatanLompat));
        }

        if (pindah > 0 && !balik)
        {
            balikBadan();
        }
        else if (pindah < 0 && balik)
        {
            balikBadan();
        }
    }

    void balikBadan()
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }
}
