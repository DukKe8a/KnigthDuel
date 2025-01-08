using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayCoin : MonoBehaviour
{
    TMP_Text scoreText;
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        UpdateScore();
    }

    void UpdateScore()
    {
        Debug.Log(ScoreCoins.CoinP1);
        Debug.Log(ScoreCoins.CoinP2);
        scoreText.text = $"{ScoreCoins.CoinP1}";
        scoreText.text = $"{ScoreCoins.CoinP2}";
    }
}
