using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsTheSequal : MonoBehaviour
{
   


    void Start()
    {


        int x = 27;
        int y = 13;
        int z = (y + x);


        if (x > y)
        {
            Debug.Log(z);
        }
    }

    
}
