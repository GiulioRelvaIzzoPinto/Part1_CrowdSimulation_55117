using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public GameObject goal;
    NavMeshAgent agent;

    //This is the start
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.transform.position);
    }

    //This is the update
    void Update()
    {

    }
} //Here is the end of the code!