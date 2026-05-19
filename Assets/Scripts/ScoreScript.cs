using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public TMP_Text Scoretext;

    public void FixedUpdate()
    {
        Scoretext.text = player.position.z.ToString("0");

    }
}
