using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public virtual float Value()
    { 
        { return value; }
    }
}
