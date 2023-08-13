using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private string inputAxis;
    [SerializeField] private float sensetive;

    private void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {
            transform.Rotate(0, Input.GetAxis(inputAxis) * -sensetive, 0);
        }
    }
}
