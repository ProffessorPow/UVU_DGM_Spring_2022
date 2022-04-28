using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public GameObject sword;

    private float rightBound = 25;
    private float topBound = 14;

    public float rotationSpeed;
    public float moveSpeed = 10;
    

    private bool isSwinging;

    [SerializeField] private Animator walking;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //controlls the running animation for the player
        float playerVelocity = playerRb.velocity.magnitude;
        if (playerVelocity > 5)
        {
            walking.SetBool("Run", true);
        }
        else if (playerVelocity <= 5)
        {
            walking.SetBool("Run", false);
        }
        

        //Allows the player to move in all directions on a 2d plane
        playerRb.AddForce(Vector3.forward * moveSpeed * verticalInput * Time.deltaTime);
        playerRb.AddForce(Vector3.right * moveSpeed * horizontalInput * Time.deltaTime);

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }


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
