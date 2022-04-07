using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using UnityEngine.SceneManagement;

public class scriptsios : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;

    RaycastHit hit;
    Ray ray;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            agent.isStopped = false;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, 100f))
            {
                agent.SetDestination(hit.point);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            agent.isStopped = true;
        }
    }

    public void Run()
    {
    }
    public void Hit()
    {
    }
    public void FootR()
    {
    }
}