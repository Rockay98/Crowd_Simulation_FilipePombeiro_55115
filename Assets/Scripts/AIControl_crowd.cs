using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl_crowd : MonoBehaviour {

    public GameObject goal;
    NavMeshAgent agent;

    void Start() {

        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.transform.position);
    }


    void Update() {

    }
}