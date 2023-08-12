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

    // �÷��̾ �� ��ü�� ������ �� ȣ��Ǵ� �Լ�
    public void PlayerAttackedEnemy()
    {
        PlayerScore++;
        UpdateScoreboard();
    }

    // �� ��ü�� �÷��̾ ������ �� ȣ��Ǵ� �Լ�
    public void EnemyAttackedPlayer()
    {
        EnemyScore++;
        UpdateScoreboard();
    }

    // ������ UI ������Ʈ
    private void UpdateScoreboard()
    {
        PlayerScoreText.text = "" + PlayerScore;
        EnemyScoreText.text = "" + EnemyScore;
    }
}
