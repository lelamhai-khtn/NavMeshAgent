using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour {
    public Transform _destination;

    NavMeshAgent _navMeshAgent;
	// Use this for initialization
	void Start () {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        if (_navMeshAgent == null)
        {
            Debug.Log("not attached to " + gameObject.name);
        } else
        {
            SetDestantion();
        }
	}

    private void SetDestantion()
    {
        Vector3 targetVector = _destination.transform.position;
        _navMeshAgent.SetDestination(targetVector);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
