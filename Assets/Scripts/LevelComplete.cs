using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject LevelCompleteAnimation;
    public void OnTriggerEnter(Collider other)
    {
        LevelCompleteAnimation.SetActive(true);
    }
}
