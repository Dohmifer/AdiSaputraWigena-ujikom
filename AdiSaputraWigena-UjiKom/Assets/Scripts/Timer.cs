using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text timeText; // UI Text untuk menampilkan waktu
    public TMP_Text gameOverText; // UI Text untuk menampilkan "Game Over"
    public float maxTime; // Waktu maksimum
    private float time; // Waktu yang berjalan
    private bool startTimer;
    public Button tryAgain;

    void Start()
    {
        tryAgain.gameObject.SetActive(false);
        StartTimer();
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (!startTimer) return;

        if (time > 0f)
        {

            time -= Time.deltaTime;
            timeText.text = Mathf.CeilToInt(time).ToString();
        }
        else
        {
            // Jika waktu habis
            time = 0f;
            Time.timeScale = 0;
            GameOver();
        }
    }

    public void StartTimer()
    {
        time = maxTime; // Set waktu awal
        timeText.text = time.ToString(); // Tampilkan waktu awal
        startTimer = true; // Mulai timer
    }

    public void StopTimer()
    {
        startTimer = false; // Hentikan timer
    }

    private void GameOver()
    {
        startTimer = false; // Hentikan timer
        tryAgain.gameObject.SetActive(false);

        // Tampilkan pesan "Game Over"
        if (gameOverText != null)
        {
            gameOverText.text = "Game Over!";
            gameOverText.gameObject.SetActive(true);
            tryAgain.gameObject.SetActive(true);
        }

        // Tambahkan logika lain seperti menghentikan game, memuat ulang scene, dll.
        Debug.Log("Game Over");
    }
}
