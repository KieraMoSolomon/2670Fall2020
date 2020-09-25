using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
    
}
