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
    public bool BirdIsAlive;

    // Start is called before the first frame update
    void Start()
    {
        // set start values
        bFlapActive = false;
        BirdIsAlive = true;

        // get logic object for collisions
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<EventManager_Script>();

    }

    // Update is called once per frame
    void Update()
    {   

        // Bird action when pressed key
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive == true)
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
        
    }

    // Actions when collision to pipe
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // activate game over screen and kill the bird
        Logic.GameOver();
        BirdIsAlive = false;
    }
}
