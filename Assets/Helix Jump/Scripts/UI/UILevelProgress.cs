using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILevelProgress : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private TextMeshProUGUI currentLevelText;
    [SerializeField] private TextMeshProUGUI nextLevelText;
    [SerializeField] private Image nextLevelImage;
    [SerializeField] private Image progressBar;
    [SerializeField] private Color mainColor;
    [SerializeField] private Color defaultColor;

    private float fillAmountStep;

    private void Start()
    {
        currentLevelText.text = levelProgress.CurrentLevel.ToString();
        nextLevelText.text = (levelProgress.CurrentLevel + 1).ToString();
        progressBar.fillAmount = 0;
        nextLevelImage.color = defaultColor;
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty || type == SegmentType.Finish)
        {
            fillAmountStep = 1 / levelGenerator.FloorAmount;

            progressBar.fillAmount += fillAmountStep;

            if (progressBar.fillAmount >= 1)
            {
                nextLevelImage.color = mainColor;
            }
        }
    }
}
