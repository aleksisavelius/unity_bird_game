using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Set References
    public Rigidbody2D MyRigidbody2;
    public EventManager_Script Logic;

    // configuration values
    public float nJumpMultiplier;
    private bool bFlapActive;
    private bool BirdAtStart;
    public bool BirdIsAlive;

    // Start is called before the first frame update
    void Start()
    {
        // set start values
        bFlapActive = false;
        BirdIsAlive = true;
        BirdAtStart = true;

        // get logic object for collisions
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<EventManager_Script>();

        // disable bird physics
        MyRigidbody2.Sleep();

    }

    // Update is called once per frame
    void Update()
    {

        // activate physics if game is running
        if (Logic.GameRunning)
        {
            MyRigidbody2.WakeUp();
            BirdAtStart = false;
            BirdIsAlive = true;
        }

        // Bird action when pressed key
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive == true && Logic.GameRunning == true)
        {   
            // activate jump velocity
            MyRigidbody2.velocity = Vector2.up * nJumpMultiplier;

            // Update flapping image
            if (bFlapActive == true)
            {

                bFlapActive = false;
            }
            else if (bFlapActive == false)
            {
                
                bFlapActive = true;
            }
        }

        // check if location needs reseting
        if (Logic.ResetBirdLocation == true && BirdAtStart == false)
        {
            ResetBirdLocation();
        }
        
    }

    // Actions when collision to pipe
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // activate game over screen and kill the bird
        Logic.GameOver();
        BirdIsAlive = false;
    }
    private void ResetBirdLocation()
    {
        Debug.Log("Bird location resetted");
        // reset position
        gameObject.transform.position = new Vector3(0,0,0);
        // reset physics
        MyRigidbody2.Sleep();
        BirdAtStart = true;

    }
}
