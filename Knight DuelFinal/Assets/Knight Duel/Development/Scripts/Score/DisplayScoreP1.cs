using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScoreP1 : MonoBehaviour
{
    TMP_Text scoreText;
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        ScoreManager.Instance.OnScoreUpdate.AddListener(UpdateScore);
    }

    void UpdateScore()
    {
        scoreText.text = $"{ScoreManager.Instance.ScoreP1}";
    }
}
