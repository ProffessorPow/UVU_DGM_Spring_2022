using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 1;

        switch (day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
        }




    }

   
}
