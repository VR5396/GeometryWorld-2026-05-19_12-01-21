using UnityEngine;
using TMPro;

public class ChancesLeft : MonoBehaviour
{
    private int NoOfChancesLeft;
    public TMP_Text NoOfChances;

    public void FixedUpdate()
    {
        NoOfChancesLeft = FindFirstObjectByType<GameManager>().NoOfLivesLeft();
        NoOfChances.text = NoOfChancesLeft .ToString();
    }

}
