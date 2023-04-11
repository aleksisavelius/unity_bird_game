using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    // Speed configuration
    public float MovementSpeed = 5;
    public float PipeDeadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move pipes cross screen
        transform.position = transform.position + (Vector3.left * MovementSpeed) * Time.deltaTime;

        // remove pipe if out side screen
        if (transform.position.x < PipeDeadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Deleted!");
        }
        
    }
}
