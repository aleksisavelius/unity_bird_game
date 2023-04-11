using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PipeSpawnScript : MonoBehaviour
{
    // class variables
    public GameObject Pipe;
    public float fSpawnRate;
    private float fTimer;
    public float fSpawnHeightOffset;

    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        // set intervall for spawn
        if (fTimer < fSpawnRate) {
            fTimer = fTimer + Time.deltaTime;
        }
        else
        {
            // spawn pipes
            Spawnpipe();

            // reset timer
            fTimer = 0;
        }
    }


    void Spawnpipe()
    {
        // set lowest and highest point
        float LowPoint = transform.position.y - fSpawnHeightOffset;
        float HighPoint = transform.position.y + fSpawnHeightOffset;

        // spawn with random height between points
        Instantiate(Pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(LowPoint,HighPoint),0), transform.rotation);
    }
}
