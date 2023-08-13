using UnityEngine;

public class UIComboText : MonoBehaviour
{
    [SerializeField] private float enabledTime;
    private float timer;

    private void Start()
    {
        enabled = false;
        timer = 0;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > enabledTime)
        {
            gameObject.SetActive(false);
            enabled = false;
            timer = 0;
        }
    }

    public void SetActiveComboText()
    {
        timer = 0;
        enabled = true;
        gameObject.SetActive(true);
    }
}
