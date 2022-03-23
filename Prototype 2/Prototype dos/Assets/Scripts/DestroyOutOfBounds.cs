using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerbound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Deletes the banana game object if it goes past a certain point
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
         // If an object goes past the player it is deleted from the the scene and a game over message is printed
        else if (transform.position.z < lowerbound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);

        }
    }
}
