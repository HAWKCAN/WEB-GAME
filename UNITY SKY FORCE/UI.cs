using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;
    public Text Score;
    public Text HighScore;
    public Text Lives;
    public Text Wave;

    public GameObject Player;
    public GameObject GameOver;

    int score = 0;
    int lives = 3;

    // Pada PERTAMA KALI game dibuka, akan memanggil ini
    private void Awake() {
        instance = this;
    }
    
    // Pada awal nya, akan menuliskan nilai default score dan lives
    void Start()
    {
        Score.text = score.ToString();
        Lives.text = "Nyawa: x" + lives.ToString();
    }

    // Akan menambah nilai score sebanyak 10 dan memodifikasi nilai score
    public void points() {
        score += 10;
        Score.text = score.ToString();
    }

    // Akan mengurangi nilai lives 1 kali dan memodifikasi nilai lives
    // Bila nilai lives <= 0, akan menghancurkan Game Objek Player, memodifikasi nilai lives menjadi 0, dan memanggil prosedur gagal
    public void live() {
        lives--;
        Lives.text = "Nyawa: x" + lives.ToString();
        if(lives <= 0) {
            Destroy(Player.gameObject);
            Lives.text = "Nyawa: x0";
            gagal();
        }
    }

    // Membuat Game Objek GameOver menjadi aktif
    public void gagal() {
        GameOver.SetActive(true);
    }

    // Memuat Scene SampleScene (Scene Game)
    public void restartButton() {
        SceneManager.LoadScene("SampleScene");
    }
}
