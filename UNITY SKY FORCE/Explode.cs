using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Setiap dimulai, akan otomatis hancur dalam waktu 5 detik
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }
}
