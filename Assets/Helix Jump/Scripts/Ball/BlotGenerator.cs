using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BlotGenerator : BallEvents
{
    [SerializeField, Header("Префаб кляксы")] private GameObject blootPrefab;
    [SerializeField] private LevelGenerator level;

    private BallMovement ballMovement;
    private List<GameObject> blots = new List<GameObject>();

    private void Start()
    {
        ballMovement = GetComponent<BallMovement>();
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Empty)
        {
            GameObject blot = Instantiate(blootPrefab);
            blot.transform.Translate(ballMovement.transform.position.x, ballMovement.transform.position.z - 1.28f, ballMovement.transform.position.y + 0.51f);

            if (blot.transform.position.y % 3 < 0.51f)
            {
                while (blot.transform.position.y % 3 < 0.51f)
                {
                    blot.transform.position += new Vector3(0, 0.01f, 0);
                }
            }

            blot.transform.eulerAngles = new Vector3(90, 0, Random.Range(0, 360));
            blot.transform.parent = level.transform;

            blots.Add(blot);
        }
    }

    public void DeleteAllBlots()
    {
        for(int i = 0; i < blots.Count; i++)
        {
            Destroy(blots[i]);
        }
        blots.Clear();
    }
}
