using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Bullet;
    public Vector3 mouseposition;
    public float speed = 10f, cooldown;

    bool isShooting = false;

    // Setiap frame, akan mengecek posisi mouse dan mengikutinya, bila diklik kiri DAN sedang tidak menembak, akan memanggil prosedur shoot
    void Update()
    {
        mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        transform.position = Vector2.Lerp(transform.position, mouseposition, speed);

        if(Input.GetMouseButton(0) && !isShooting) {
            shoot();
        }
    }

    // Membuat variabel isShooting menjadi True, dan memanggil Game Objek bernama Bullet dengan posisi dan lokasi Player
    // Kemudian, akan memanggil prosedur interval dengan jeda sebanyak variabel cooldown
    public void shoot() {
        isShooting = true;
        Instantiate(Bullet, transform.position, quaternion.identity);
        Invoke("interval", cooldown);
    }

    // Mengembalikan nilai isShooting menjadi True
    private void interval() {
        isShooting = false;
    }
}
