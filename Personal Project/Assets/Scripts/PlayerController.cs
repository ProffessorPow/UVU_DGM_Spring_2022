using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject goblin;

    private float rightBound = 25;
    private float topBound = 14;
    private int playerHealth = 3;

    public float rotationSpeed;
    public float moveSpeed = 10;
    public float pushbackForce;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        goblin = GameObject.Find("Goblin");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goblin"))
        {
            playerRb.AddForce((transform.position - goblin.transform.position) * pushbackForce, ForceMode.Impulse);
            playerHealth--;
            Debug.Log(playerHealth);
        }
    }
}
