using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventManager_Script : MonoBehaviour
{

    // Script references
    public int playerscore;
    public Text score_text;
    public GameObject GameOverScreen;

    // Add score to player
    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {
        playerscore = playerscore + ScoreToAdd;
        score_text.text = "Score: " + playerscore.ToString();
    }

    // Restart game functions
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

    // Game over functions
    public void GameOver() 
    {
        // Set game over screen active
        GameOverScreen.SetActive(true);
    }

}
