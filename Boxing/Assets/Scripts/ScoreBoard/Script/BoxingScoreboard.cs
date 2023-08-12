using UnityEngine;
using TMPro;

public class BoxingScoreboard : MonoBehaviour
{
    private int PlayerScore = 0;
    private int EnemyScore = 0;

    public TextMeshProUGUI PlayerScoreText;
    public TextMeshProUGUI EnemyScoreText;

    private void Start()
    {
        UpdateScoreboard();
    }

    // 플레이어가 적 객체를 공격할 때 호출되는 함수
    public void PlayerAttackedEnemy()
    {
        PlayerScore++;
        UpdateScoreboard();
    }

    // 적 객체가 플레이어를 공격할 때 호출되는 함수
    public void EnemyAttackedPlayer()
    {
        EnemyScore++;
        UpdateScoreboard();
    }

    // 점수판 UI 업데이트
    private void UpdateScoreboard()
    {
        PlayerScoreText.text = "" + PlayerScore;
        EnemyScoreText.text = "" + EnemyScore;
    }
}
