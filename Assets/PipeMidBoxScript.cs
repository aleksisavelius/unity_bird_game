using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMidBoxScript : MonoBehaviour
{
    public EventManager_Script Logic;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<EventManager_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Check collision event when triggered
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check that bid did collision
        if (collision.gameObject.layer == 3)
        {
            // Add score value
            Logic.AddScore(1);
        }
        

    }
}
