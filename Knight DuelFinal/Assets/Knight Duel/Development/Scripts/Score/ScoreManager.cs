using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Patron de Diseño Singleton
public class ScoreManager
{
    public static ScoreManager _instance;
    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new ScoreManager();

            return _instance;
        }
    }
    public int ScoreP1 { get; private set; } = 0;
    public int ScoreP2 { get; private set; } = 0;
    public UnityEvent OnScoreUpdate { get; private set; } = new ();

    public void AddScoreP1(int score)
    {
        ScoreP1 += score;
        OnScoreUpdate.Invoke();
        if (ScoreP1 == 15)
        {
            ScoreCoins.CoinP1 = +2;
            Debug.Log(ScoreCoins.CoinP1);
            PlayerManager.Instance.nextLevel();
        }
    }

    public void AddScoreP2(int score)
    {
        ScoreP2 += score;
        OnScoreUpdate.Invoke();
        if (ScoreP2 == 15)
        {
            ScoreCoins.CoinP2 = +1;
            PlayerManager.Instance.nextLevel();
        }
    }
}
