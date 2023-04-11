using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager_Script : MonoBehaviour
{
    public int playerscore;
    public Text score_text;

    // Add score to player
    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {
        playerscore = playerscore + ScoreToAdd;
        score_text.text = "Score: " + playerscore.ToString();
    }


}
