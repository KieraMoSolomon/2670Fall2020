using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, onEnableEvent;
    public float holdTime = 1;
    public bool repeatOnStart;
    
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();

        while (repeatOnStart)
        {
            yield return new WaitForSeconds(holdTime);
            startEvent.Invoke();
        }
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }
}
