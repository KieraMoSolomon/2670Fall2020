using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public UnityEvent handlerEvent;
    public GameAction gameAction;
    public float holdTime = 3f;
    private void Start()
    {
        gameAction.action += ActionHandler;
    }

    private void ActionHandler()
    {
        Invoke(nameof(OnActionHandler),holdTime);
    }

    private void OnActionHandler()
    {
        handlerEvent.Invoke();
    }
}
