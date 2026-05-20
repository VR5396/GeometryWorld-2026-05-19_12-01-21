using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFailedScript : MonoBehaviour
{
    public void OnLevelFailed()
    {
        SceneManager.LoadScene(0);
    }
    
}
