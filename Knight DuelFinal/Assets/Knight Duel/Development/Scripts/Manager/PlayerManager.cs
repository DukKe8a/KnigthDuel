using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] int level;
    public int x = 1;

    public static PlayerManager _instance;
    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<PlayerManager>();

            return _instance;
        }
    }

    public enum Players { none, Player1, Player2}
    public Players PlayerWin = Players.none;
    public Players PlayerPoint = Players.none;

    public void setPlayerWin(Players PlayerLoss) 
    {
        switch (PlayerLoss)
        {
            case Players.Player1:
                PlayerWin = Players.Player2;
                ScoreCoins.CoinP2 = +1;
                Debug.Log(ScoreCoins.CoinP2);
                break;

            case Players.Player2:
                PlayerWin = Players.Player1;
                ScoreCoins.CoinP1 = +1;
                Debug.Log(ScoreCoins.CoinP1);
                break;
        }

    }

    public void setPlayerPoint(Players Point)
    {
        switch (Point)
        {
            case Players.Player1:
                PlayerPoint = Players.Player1;
                ScoreManager.Instance.AddScoreP1(1);
                break;

            case Players.Player2:
                PlayerPoint = Players.Player1;
                ScoreManager.Instance.AddScoreP2(1);
                break;
        }
    }

    public void nextLevel() 
    {
        SceneManager.LoadScene(level);
    }
}
