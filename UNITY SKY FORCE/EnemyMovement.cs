using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Explosion;
    public float enemySpeed = 10f;

    // Setiap frame, Musuh akan berjalan dengan kecepatan yang ditentukan, otomatis hancur bila mencapai titik y < -9 ATAU y > 15
    void Update()
    {
        transform.Translate(Vector2.up * enemySpeed * Time.deltaTime);
        if(transform.position.y < -9 || transform.position.y > 15) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            UI.instance.points();
        }

        if(other.gameObject.CompareTag("MC")) 
        {
            Destroy(gameObject);

            UI.instance.live();
        }

        if(other.gameObject.CompareTag("Enemy")) 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        Instantiate(Explosion, transform.position, transform.rotation);
    }
}
