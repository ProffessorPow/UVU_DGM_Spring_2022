using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSequalSwitch : MonoBehaviour
{
    
    void Start()
    {
        double salary = 16;

        switch (salary)
        {
            case 16:
                Debug.Log("Not bad my friend");
                break;
            case 12:
                Debug.Log("Alright, but it could be better");
                break;
            default:
                Debug.Log("Wow, is that even legal?");
                break;
        }
    }

    
}
