using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;
    public float delayTime = 1f;

    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(delayTime);
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return wfs;
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}