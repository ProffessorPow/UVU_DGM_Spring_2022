using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorRotation : MonoBehaviour
{
    public GameObject propeller;
    public float rotation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rotation);
    }
}
