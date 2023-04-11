using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Set References
    public Rigidbody2D MyRigidbody2;

    // configuration values
    public float nJumpMultiplier;
    private bool bFlapActive;

    // Start is called before the first frame update
    void Start()
    {
        // set start values
        bFlapActive = false;
        

    }

    // Update is called once per frame
    void Update()
    {   

        // Bird action when pressed key
        if (Input.GetKeyDown(KeyCode.Space) == true)
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
}
