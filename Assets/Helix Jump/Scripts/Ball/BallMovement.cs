using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField, Header("Animation")] private Animator animator;
    [SerializeField, Header("Min скорость падени€")] private float fallSpeedMin;
    [SerializeField, Header("Max скорость падени€")] private float fallSpeedMax;
    [SerializeField, Header("—корость ускорени€ падени€")] private float fallSpeedAcceletation;
    [SerializeField, Header("¬ысота падени€")] private float fallHeight;

    private float floorY;
    private float fallSpeed;

    private void Start()
    {
        floorY = 3;
        enabled = false;
    }
    private void Update()
    {
        if (transform.position.y > floorY)
        {
            transform.Translate(0, -fallSpeed * Time.deltaTime, 0);

            if (fallSpeed < fallSpeedMax) fallSpeed += fallSpeedAcceletation * Time.deltaTime;
            else fallSpeed = fallSpeedMax;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, floorY, transform.position.z);
            enabled = false;
        }
    }
    public void Jump()
    {
        fallSpeed = fallSpeedMin;
        animator.speed = 1;
    }

    public void Fall(float startFloatY)
    {
        animator.speed = 0;
        enabled = true;
        floorY = startFloatY - fallHeight;
    }

    public void Stop()
    {
        animator.speed = 0;
    }
}
