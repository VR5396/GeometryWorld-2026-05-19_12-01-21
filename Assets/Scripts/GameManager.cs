using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int NoOfChancesToGive;
    public static int RestartNumb = 0;
    public static int NoOfChancesLeft;
    public GameObject LevelFailedAnimation;
    public GameObject MobileTouchControls;

    private void Start()
    {
        NoOfChancesLeft = NoOfChancesToGive - RestartNumb;
    }
    public void Restart()
    {

        RestartNumb = RestartNumb + 1;
        NoOfChancesLeft = NoOfChancesToGive - RestartNumb;
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
    public int NoOfLivesLeft()
    {
        return NoOfChancesLeft;
    }
    public void OnLevelFailed()
    {
        Invoke("Restart", 3f);
    }
    public void OnLevelCompleted()
    {
        Invoke("LoadNextLevel", 2f);
        MobileTouchControls.SetActive(false);
    }
}
