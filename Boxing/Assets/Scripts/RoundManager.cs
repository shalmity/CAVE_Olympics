using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    private float minTime;
    
    public bool isRound;
    public float roundTime;
    public BoxingScoreboard scoreboard;
    private int score;

    void Start()
    {
        DontDestroyOnLoad(this);
        roundTime = 60f;
        minTime = 0f;
        isRound = false;
        scoreboard = GameObject.Find("ScoreBoardManage").GetComponent<BoxingScoreboard>();
    }

    void Update()
    {
        roundTime -= Time.deltaTime;
        int timer = (int)roundTime;
        scoreboard.timeText[0].text = "Time left " + timer.ToString();
        scoreboard.timeText[1].text = "Time left " + timer.ToString();
        
        score = scoreboard.PlayerScore;
        if (roundTime <= minTime)
        {
            roundTime = 10f;
            isRound = false;
        }
    }
}
