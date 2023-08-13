using UnityEngine;
using TMPro;

public class UIHighscoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private void Start()
    {
        SetHighscore();
        gameObject.SetActive(true);
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            gameObject.SetActive(false);
        }

        if (type == SegmentType.Trap || type == SegmentType.Finish)
        {
            SetHighscore();
            gameObject.SetActive(true);
        }
    }

    private void SetHighscore()
    {
        highScoreText.text = "Highscore: " + scoresCollector.Highscore.ToString();
    }
}
