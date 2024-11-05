using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pet : MonoBehaviour
{
    [Header("Stat")]
    public float walkSpeed;
    public float runSpeed;

    [Header("AI")]
    NavMeshAgent agent;
    public float petPosition;
    public Vector3 taget;

    Animator animator;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
       

    }
    private void Start()
    {
        ChasingMaster();
    }   
    private void Update()
    {
        taget = CharcterManager.Instance.Player.transform.position;
        Debug.Log(agent.remainingDistance);
        PetPosition();
    }

    private void PetPosition()
    {
       
            agent.stoppingDistance = petPosition;
        ChasingMaster();

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            agent.velocity = Vector3.zero;
            animator.SetBool("Moving", false);
        }
        else
        {
            animator.SetBool("Moving", true);
        }

        
    }
    private void ChasingMaster()
    {
        
        agent.SetDestination(taget);
        


    }
}
