using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemySolo;
    public GameObject Enemy3Horizontal;
    public GameObject Enemy3Vertical;
    public GameObject Enemy3Triangel;
    public GameObject Enemy3MirrorTriangel;
    public GameObject EnemyBack;
    public GameObject EnemyTank;
    public GameObject Island;
    private float enemyPosition;
    private float islandPosition;
    private int enemyPick;
    private Quaternion sudut = Quaternion.Euler(0, 0, 0);

    public float spawnSpeed;

    // Pada saat dimulai, akan memanggil prosedur enemySpawn selama spawnSpeed detik DAN
    // memanggil prosedur islan selama 5 detik
    void Start()
    {
        Invoke("enemySpawn", spawnSpeed);
        Invoke("island", 5);
    }

    // Membuat nilai enemyPick dan enemyPosition secara acak, lalu akan melakukan pengecekan dari enemyPick
    // Setelah itu, akan memanggil Game Objek musuh sesuai dengan nilai yang didapatkan
    // Terakhir, akan memanggil prosedur enemySpawn kembali dengan jeda spawnSpeed detik
    private void enemySpawn() {
        enemyPick = Random.Range(1, 7);
        enemyPosition = Random.Range(5, -5);

        if(enemyPick == 1) {
            Instantiate(EnemySolo, new Vector3(enemyPosition, transform.position.y, 0), transform.rotation);
        } else if(enemyPick == 2) {
            Instantiate(Enemy3Horizontal, new Vector3(enemyPosition, transform.position.y, 0), transform.rotation);
            Instantiate(Enemy3Horizontal, new Vector3(enemyPosition + 1, transform.position.y, 0), transform.rotation);
            Instantiate(Enemy3Horizontal, new Vector3(enemyPosition - 1, transform.position.y, 0), transform.rotation);
        } else if(enemyPick == 3) {
            Instantiate(Enemy3Vertical, new Vector3(enemyPosition, transform.position.y, 0), transform.rotation);
            Instantiate(Enemy3Vertical, new Vector3(enemyPosition, transform.position.y + 1, 0), transform.rotation);
            Instantiate(Enemy3Vertical, new Vector3(enemyPosition, transform.position.y + 2, 0), transform.rotation);
        } else if(enemyPick == 4) {
            Instantiate(Enemy3Triangel, new Vector3(enemyPosition, transform.position.y, 0), transform.rotation);
            Instantiate(Enemy3Triangel, new Vector3(enemyPosition + 1, transform.position.y - 1, 0), transform.rotation);
            Instantiate(Enemy3Triangel, new Vector3(enemyPosition - 1, transform.position.y - 1, 0), transform.rotation);
        } else if(enemyPick == 5) {
            Instantiate(Enemy3MirrorTriangel, new Vector3(enemyPosition, transform.position.y, 0), transform.rotation);
            Instantiate(Enemy3MirrorTriangel, new Vector3(enemyPosition + 1, transform.position.y + 1, 0), transform.rotation);
            Instantiate(Enemy3MirrorTriangel, new Vector3(enemyPosition - 1, transform.position.y + 1, 0), transform.rotation);
        } else if(enemyPick == 6) {
            Instantiate(EnemyBack, new Vector3(enemyPosition, transform.position.y - 11, 0), sudut);
        } else if(enemyPick == 7) {
            Instantiate(EnemyTank, new Vector3(enemyPosition, transform.position.y, 0), transform.rotation);
        }
        Invoke("enemySpawn", spawnSpeed);
    }

    // Memilih nilai secara acak untuk menentukan lokasi Game Objek islandPosition
    // Kemudian, akan memanggil prosedur island dengan jeda 9 detik
    private void island() {
        islandPosition = Random.Range(5, -5);
        Instantiate(Island, new Vector3(islandPosition, transform.position.y, 0), transform.rotation);
        Invoke("island", 9);
    }
}
