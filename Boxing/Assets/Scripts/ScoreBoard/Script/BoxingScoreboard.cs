using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class BoxingScoreboard : MonoBehaviour
{
    private int PlayerScore = 0;
    private int EnemyScore = 0;

    public List<TextMeshProUGUI> PlayerScoreText;
    public List<TextMeshProUGUI> EnemyScoreText;

    private void Start()
    {
        PlayerScoreText.Add(GameObject.Find("PlayerScore").GetComponent<TextMeshProUGUI>());
        PlayerScoreText.Add(GameObject.Find("PlayerScore2").GetComponent<TextMeshProUGUI>());
        EnemyScoreText.Add(GameObject.Find("EnemyScore").GetComponent<TextMeshProUGUI>());
        EnemyScoreText.Add(GameObject.Find("EnemyScore2").GetComponent<TextMeshProUGUI>());
        UpdateScoreboard();
    }

    public void PlayerAttackedEnemy()
    {
        PlayerScore++;
        UpdateScoreboard();
    }

    public void EnemyAttackedPlayer()
    {
        EnemyScore++;
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        PlayerScoreText[0].text = "" + PlayerScore;
        PlayerScoreText[1].text = "" + PlayerScore;
        EnemyScoreText[0].text = "" + EnemyScore;
        EnemyScoreText[1].text = "" + EnemyScore;
    }
}
