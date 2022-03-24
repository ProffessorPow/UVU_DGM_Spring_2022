using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time;

    // Update is called once per frame
    void Update()
    {

        if (Time.fixedTime >= time)
        {

            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                time = Time.fixedTime + 0.6f;
            }

        }
    }
}
