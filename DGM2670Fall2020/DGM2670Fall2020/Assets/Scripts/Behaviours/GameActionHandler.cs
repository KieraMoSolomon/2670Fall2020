using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public UnityEvent handlerEvent;
    public GameAction gameAction;
    private void Start()
    {
        gameAction.action += ActionHandler;
    }

    private void ActionHandler()
    {
        handlerEvent.Invoke();
    }
}
