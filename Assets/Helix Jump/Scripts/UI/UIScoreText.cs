using UnityEngine;
using TMPro;

public class UIScoreText : BallEvents
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ScoresCollector scoresCollector;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            scoreText.text = scoresCollector.Scores.ToString();
        }
    }
}
