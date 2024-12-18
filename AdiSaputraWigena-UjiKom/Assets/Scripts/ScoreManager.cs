using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // TMP Text untuk menampilkan skor
    private int score = 0; // Variabel untuk menyimpan skor

    // Method untuk menambah skor
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Method untuk memperbarui teks skor di layar
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}