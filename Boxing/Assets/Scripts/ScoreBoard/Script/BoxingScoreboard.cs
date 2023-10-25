using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class BoxingScoreboard : MonoBehaviour
{
    public int PlayerScore = 0;
    public List<TextMeshProUGUI> PlayerScoreText;
    public List<TextMeshProUGUI> timeText;

    private void Start()
    {
        PlayerScoreText.Add(GameObject.Find("PlayerScore").GetComponent<TextMeshProUGUI>());
        PlayerScoreText.Add(GameObject.Find("PlayerScore2").GetComponent<TextMeshProUGUI>());
        timeText.Add(GameObject.Find("Time").GetComponent<TextMeshProUGUI>());
        timeText.Add(GameObject.Find("Time2").GetComponent<TextMeshProUGUI>());
        UpdateScoreboard();
    }

    public void PlayerAttackedEnemy()
    {
        PlayerScore++;
        UpdateScoreboard();
    }

    public void EnemyAttackedPlayer()
    {
        PlayerScore--;
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        PlayerScoreText[0].text = "" + PlayerScore;
        PlayerScoreText[1].text = "" + PlayerScore;
    }
}
