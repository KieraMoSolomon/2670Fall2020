﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
    private bool canHunt, canPatrol;
    private NavMeshAgent agent;
    private WaitForFixedUpdate wffu;
    private WaitForSeconds wfs;

    public float holdTime = 2f;
    public Transform player;
    
    public List<Transform> patrolPoints;
    private int i = 0;
    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
        wffu = new WaitForFixedUpdate();
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        agent.destination = player.position;
        var distance = agent.remainingDistance;
        while (distance <= 0.25f)
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }
        yield return wfs;
        if (canHunt)
        {
            StartCoroutine(OnTriggerEnter(other));
        }
        else
        {
            StartCoroutine(Patrol());
        }
    }

    private IEnumerator Patrol()
    {
        canPatrol = true;
        if (agent.pathPending || !(agent.remainingDistance < 0.5f)) return;
        agent.destination = patrolPoints[i].position;
        i = (i + 1) % patrolPoints.Count;
        yield return wfs;
    }
    
    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
    }
}
