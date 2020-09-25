using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class MouseEventBehaviour : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
    
}
