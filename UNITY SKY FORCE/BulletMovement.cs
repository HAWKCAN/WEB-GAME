using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;

    // Setiap frame, Peluru akan berjalan dengan kecepatan yang ditentukan, otomatis hancur bila mencapai titik y > 5
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);

        if(transform.position.y > 5) {
            Destroy(gameObject);
        }
    }
}
