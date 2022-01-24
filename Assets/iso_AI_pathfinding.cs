﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class iso_AI_pathfinding : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {
   
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}