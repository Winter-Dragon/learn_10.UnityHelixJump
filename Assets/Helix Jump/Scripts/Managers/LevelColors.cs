using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LevelProgress))]

[System.Serializable]
public class LevelPallete
{
    public Color AxisColor;
    public Color DefaultSegmentColor;
    public Color TrapSegmentColor;
    public Color BackgroundTopColor;
    public Color BackgroundBottomColor;
}

public class LevelColors : MonoBehaviour
{
    [SerializeField] private LevelPallete[] pallete;
    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material defaultSegmentMaterial;
    [SerializeField] private Material trapSegmentMaterial;
    [SerializeField] private Camera backgroundTop;
    [SerializeField] private Image backgroundBottom;

    private LevelProgress levelProgress;

    private void Start()
    {
        levelProgress = GetComponent<LevelProgress>();

        int index = Random.Range(0, pallete.Length);

        switch (levelProgress.CurrentLevel % 10)
        {
            case 1:
                axisMaterial.color = pallete[0].AxisColor;
                defaultSegmentMaterial.color = pallete[0].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[0].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[0].BackgroundTopColor;
                backgroundBottom.color = pallete[0].BackgroundBottomColor;
                break;

            case 2:
                axisMaterial.color = pallete[1].AxisColor;
                defaultSegmentMaterial.color = pallete[1].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[1].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[1].BackgroundTopColor;
                backgroundBottom.color = pallete[1].BackgroundBottomColor;
                break;

            case 3:
                axisMaterial.color = pallete[2].AxisColor;
                defaultSegmentMaterial.color = pallete[2].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[2].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[2].BackgroundTopColor;
                backgroundBottom.color = pallete[2].BackgroundBottomColor;
                break;

            case 4:
                axisMaterial.color = pallete[3].AxisColor;
                defaultSegmentMaterial.color = pallete[3].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[3].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[3].BackgroundTopColor;
                backgroundBottom.color = pallete[3].BackgroundBottomColor;
                break;

            case 5:
                axisMaterial.color = pallete[4].AxisColor;
                defaultSegmentMaterial.color = pallete[4].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[4].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[4].BackgroundTopColor;
                backgroundBottom.color = pallete[4].BackgroundBottomColor;
                break;

            case 6:
                axisMaterial.color = pallete[5].AxisColor;
                defaultSegmentMaterial.color = pallete[5].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[5].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[5].BackgroundTopColor;
                backgroundBottom.color = pallete[5].BackgroundBottomColor;
                break;

            case 7:
                axisMaterial.color = pallete[6].AxisColor;
                defaultSegmentMaterial.color = pallete[6].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[6].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[6].BackgroundTopColor;
                backgroundBottom.color = pallete[6].BackgroundBottomColor;
                break;

            case 8:
                axisMaterial.color = pallete[7].AxisColor;
                defaultSegmentMaterial.color = pallete[7].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[7].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[7].BackgroundTopColor;
                backgroundBottom.color = pallete[7].BackgroundBottomColor;
                break;

            case 9:
                axisMaterial.color = pallete[8].AxisColor;
                defaultSegmentMaterial.color = pallete[8].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[8].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[8].BackgroundTopColor;
                backgroundBottom.color = pallete[8].BackgroundBottomColor;
                break;

            case 0:
                axisMaterial.color = pallete[9].AxisColor;
                defaultSegmentMaterial.color = pallete[9].DefaultSegmentColor;
                trapSegmentMaterial.color = pallete[9].TrapSegmentColor;
                backgroundTop.backgroundColor = pallete[9].BackgroundTopColor;
                backgroundBottom.color = pallete[9].BackgroundBottomColor;
                break;
        }
    }
}
