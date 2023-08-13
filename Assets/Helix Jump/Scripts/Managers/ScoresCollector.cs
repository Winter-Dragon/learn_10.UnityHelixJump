using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private UIComboText UIcomboText;
    private int scores;
    public int Scores => scores;

    private int highscore;
    public int Highscore => highscore;

    private bool combo = false;

    protected override void Awake()
    {
        base.Awake();

        LoadProgress();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            if (combo == true)
            {
                scores += levelProgress.CurrentLevel;
                UIcomboText.SetActiveComboText();
            }

            scores += levelProgress.CurrentLevel;

            if (scores >= highscore) 
            {
                highscore = scores;
                SaveProgress();
            }

            combo = true;
        }

        if (type != SegmentType.Empty)
        {
            combo = false;
        }
    }

    private void SaveProgress()
    {
        PlayerPrefs.SetInt("ScoresCollector:highscore", highscore);
    }

    private void LoadProgress()
    {
        highscore = PlayerPrefs.GetInt("ScoresCollector:highscore", 0);
    }
}
