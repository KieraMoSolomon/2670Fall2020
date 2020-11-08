using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
    private bool canNav;
    private NavMeshAgent agent;
    private WaitForFixedUpdate wffu;
    
    public Transform player;
    private void Start()
    {
        wffu = new WaitForFixedUpdate();
        agent = GetComponent<NavMeshAgent>();
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canNav = true;
        while (canNav)
        {
            yield return wffu;
            agent.destination = player.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canNav = false;
    }
}
