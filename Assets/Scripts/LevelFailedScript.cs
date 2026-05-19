using UnityEngine;

public class LevelFailedScript : MonoBehaviour
{
    public void OnLevelFailed()
    {
        Application.Quit();
        Debug.Log("GameEnded");
    }
    
}
