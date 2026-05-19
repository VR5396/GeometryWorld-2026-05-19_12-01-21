using UnityEngine;

public class LevelCompleteScript : MonoBehaviour
{
    public void OnCompletingLevel()
    {
        FindFirstObjectByType<GameManager>().OnLevelCompleted();
    }
}
