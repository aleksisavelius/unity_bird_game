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
    public bool ResetBirdLocation;
    public Text score_text;
    public GameObject GameOverScreen;
    public GameObject StartGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        //StartGameScreenOn();
        GameRunning = false;
        ResetBirdLocation = false;
    }

    // Add score to player
    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {
        playerscore = playerscore + ScoreToAdd;
        score_text.text = "Score: " + playerscore.ToString();
    }

    // Start game functions
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // start game pressed
        ResetBirdLocation = false;
        GameRunning = true;
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
        // reset bird location
        ResetBirdLocation = true;

        // Set start game screen active
        GameOverScreen.SetActive(false);
        StartGameScreen.SetActive(true);


    }

    // Game over screen
    public void GameOver() 
    {
        // Set game over screen active
        GameRunning = false;
        GameOverScreen.SetActive(true);
    }

}
