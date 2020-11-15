using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class CharacterStateMachineData : ScriptableObject
{
    public enum characterStates
    {
        StandardWalk,
        NoGravWalk,
        WallCrawl,
        Idle
    }
    
    public characterStates value;

    /*public UnityEvent onEnableEvent;
    public void OnEnable()
    {
        onEnableEvent.Invoke();
    }*/

    public void StandardWalk()
    {
        value = characterStates.StandardWalk;
    }
    
    public void WallCrawl()
    {
        value = characterStates.WallCrawl;
    }
    
    public void Idle()
    {
        value = characterStates.Idle;
    }

    public void NoGravWalk()
    {
        value = characterStates.NoGravWalk;
    }
}
