using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int NoOfChancesToGive;
    public static int RestartNumb = 0;
    public GameObject LevelFailedAnimation;
    public GameObject MobileTouchControls;
    
    public void Restart()
    {

        RestartNumb = RestartNumb + 1;
        if (RestartNumb < NoOfChancesToGive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            LevelFailedAnimation.SetActive(true);
            MobileTouchControls.SetActive(false);

        }
        Debug.Log(RestartNumb);
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnLevelFailed()
    {
        Invoke("Restart", 2f);
    }
    public void OnLevelCompleted()
    {
        Invoke("LoadNextLevel", 2f);
        MobileTouchControls.SetActive(false);
    }
}
