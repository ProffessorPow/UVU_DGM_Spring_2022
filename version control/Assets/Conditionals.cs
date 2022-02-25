using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int x = 35;
    int y = 22;
    
    // Start is called before the first frame update
    void Start()
    {
        if (x < y)
        {
            Debug.Log("Perfect");
        }
        else if (x == y)
        {
            Debug.Log("Not quite");
        }
        else if (x > y)
        {
            Debug.Log("Almost there");
        }
        else
        {
            Debug.Log("You did it!");
        }
    }

   
}
