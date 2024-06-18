using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ReactiveNPCMovement : MonoBehaviour
{
    public Transform destination; 
    private NavMeshAgent agent;
    private bool isMoving = false; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = 1f; 
    }

    void Update()
    {
        
        if (isMoving)
        {
            agent.SetDestination(destination.position);
        }
    }

    public void ToggleMovement()
    {
        isMoving = !isMoving; 

        if (isMoving)
        {
            agent.SetDestination(destination.position);
        }
        else 
        {
            agent.ResetPath();
        }
    }
}
