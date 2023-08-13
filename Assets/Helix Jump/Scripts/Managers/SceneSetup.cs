using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] LevelGenerator levelGenerator;
    [SerializeField] LevelProgress levelProgress;
    [SerializeField] BallController ballController;

    private void Start()
    {
        levelGenerator.GenerateLevel(levelProgress.CurrentLevel);

        ballController.transform.position = new Vector3(ballController.transform.position.x, levelGenerator.LastFloorY, ballController.transform.position.z);
    }
}
