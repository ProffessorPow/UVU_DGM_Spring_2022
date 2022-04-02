using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    private float rightBound = 25;
    private float topBound = 14;
    
    public float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Allows the player to move in all directions on a 2d plane
        playerRb.AddForce(Vector3.forward * moveSpeed * verticalInput * Time.deltaTime);
        playerRb.AddForce(Vector3.right * moveSpeed * horizontalInput * Time.deltaTime);


        //Sets the boundaries for the players movement
        if (transform.position.z > topBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topBound);
        }
        if (transform.position.z < -topBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -topBound);
        }
        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -rightBound)
        {
            transform.position = new Vector3(-rightBound, transform.position.y, transform.position.z);
        }
    }
}
