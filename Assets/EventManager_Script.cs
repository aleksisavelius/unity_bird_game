using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventManager_Script : MonoBehaviour
{

    // Script references
    public int playerscore;
    public bool GameRunning;
    public bool StartScreenActive;
    public Text score_text;
    public GameObject GameOverScreen;
    public GameObject StartGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        //StartGameScreenOn();
        GameRunning = false;
        StartScreenActive = true;
    }

    // Add score to player
    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {
        if (GameRunning == true)
        {
            playerscore = playerscore + ScoreToAdd;
            score_text.text = "Score: " + playerscore.ToString();
        }
    }

    // Start game functions
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // start game pressed
        GameRunning = true;
        StartScreenActive = false;
        StartGameScreen.SetActive(false);
    }

    // Restart game functions
    public void RestartGame() 
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

    // Start game screen
    public void StartGameScreenOn()
    {

        Debug.Log("Restart button pressed");

        // Set start game screen active
        GameOverScreen.SetActive(false);
        StartGameScreen.SetActive(true);
        StartScreenActive = true;

        // reset score
        playerscore = 0;
        score_text.text = "Score: " + playerscore.ToString();


    }

    // Game over screen
    public void GameOver() 
    {
        // Set game over screen active
        GameRunning = false;
        GameOverScreen.SetActive(true);
    }

}
