using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dowhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i;

        for (i = -1; i <= 10; i++)
        {
            Debug.Log(i);
        do
        {
            Debug.Log("All is well here");
        }
        while (i <= 10) ;

        }

        
    }

   
}
