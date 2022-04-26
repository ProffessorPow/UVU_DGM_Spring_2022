using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class FloatData : ScriptableObject
{

    public float number;


    public void AddToNumber(float decim)
    {
        number += decim;
    }
}
