using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField, Header("Ось")] private Transform axis;
    [SerializeField, Header("Префаб этажа")] private Floor floorPrefab;

    [Header("Settings")]
    [SerializeField] private int minFloorAmount;
    [SerializeField] private int amountEmptySegments;
    [SerializeField] private int minTrapSegments;
    [SerializeField] private int maxTrapSegments;

    private int floorHeight = 3;

    private int floorAmount = 0;
    public float FloorAmount => floorAmount;

    private float lastFloorY = 0;
    public float LastFloorY => lastFloorY;

    public void GenerateLevel(int level)
    {
        DestroyLevel();

        floorAmount = minFloorAmount + level;

        axis.transform.localScale = new Vector3(1, floorAmount * floorHeight + floorHeight, 1);

        for (int i = 0; i < floorAmount; i++)
        {
            Floor floor = Instantiate(floorPrefab, transform);      // этаж ... = Создать(Что создать, родитель объекта)
            floor.transform.Translate(0, i * floorHeight, 0);
            floor.name = "Floor " + (i + 1);

            if (i == 0) floor.SetFinishSegments();

            if (i > 0 && i < floorAmount - 1)
            {
                floor.SetRandomRotation();
                floor.AddEmptySegments(2);
                floor.AddRandomTrapSegments(Random.Range(minTrapSegments, maxTrapSegments + 1));
            }

            if (i == floorAmount - 1)
            {
                floor.AddEmptySegments(amountEmptySegments);

                lastFloorY = floor.transform.position.y;
            }
        }
    }

    private void DestroyLevel()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == axis) continue;

            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
