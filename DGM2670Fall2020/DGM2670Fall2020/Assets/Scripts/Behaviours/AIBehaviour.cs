using System.Collections;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    public bool canNav = true;
    private WaitForFixedUpdate wffu;
    public float holdTime = 1f;
    private WaitForSeconds wfs;
    private void Start()
    {
        wffu = new WaitForFixedUpdate();
        wfs = new WaitForSeconds(holdTime);
        agent = GetComponent<NavMeshAgent>();
    }

    private IEnumerator Navigate()
    {
        yield return wfs;
        canNav = true;
        while (canNav)
        {
            yield return wffu;
            agent.destination = player.position;
            print("walking");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canNav = false;
        StartCoroutine(Navigate());
    }

    private void OnTriggerExit(Collider other)
    {
        canNav = false;
    }
}
