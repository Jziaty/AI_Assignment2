using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {

    NavMeshAgent agent;
    Animator anim;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    public void Lose()
    {
        DisableScene();
        anim.SetTrigger("Lose");
    }

    void DisableScene()
    {
        GetComponentInChildren<Camera>().enabled = true;
        agent.isStopped = true;
    }
}
