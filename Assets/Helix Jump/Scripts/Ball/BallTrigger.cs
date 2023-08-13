using UnityEngine;

public abstract class BallTrigger : MonoBehaviour
{
    private bool isTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isTriggered == true) return;

        isTriggered = true;

        TriggerEnter(other);
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggered = false;
    }

    protected virtual void TriggerEnter(Collider other) { }
}
