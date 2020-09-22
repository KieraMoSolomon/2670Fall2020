using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class FireAmmo : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public void OnMouseDown()
    {
        mouseDownEvent.invoke();
    }
    
}
