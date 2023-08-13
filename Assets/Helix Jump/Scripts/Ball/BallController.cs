using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BallMovement))]

public class BallController : BallTrigger
{
    private BallMovement ballMovement;
    private BlotGenerator blotGenerator;

    [HideInInspector] public UnityEvent<SegmentType> CollisionSegment;
    private void Start()
    {
        ballMovement = GetComponent<BallMovement>();
        blotGenerator = GetComponent<BlotGenerator>();
    }

    protected override void TriggerEnter(Collider other)
    {
        Segment floorSegment = other.GetComponent<Segment>();

        if (floorSegment != null)
        {
            switch (floorSegment.Type)
            {
                case SegmentType.Default:
                    ballMovement.Jump();
                    break;

                case SegmentType.Empty:
                    ballMovement.Fall(other.transform.position.y);
                    FloorDestroyer floorDestroyer = other.transform.parent.GetComponent<FloorDestroyer>();
                    floorDestroyer.enabled = true;
                    blotGenerator.DeleteAllBlots();
                    break;

                case SegmentType.Finish:
                    ballMovement.Stop();
                    break;

                case SegmentType.Trap:
                    ballMovement.Stop();
                    break;
            }

            CollisionSegment.Invoke(floorSegment.Type);
        }
    }
}
