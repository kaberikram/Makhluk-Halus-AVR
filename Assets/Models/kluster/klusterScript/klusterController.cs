using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class klusterController : MonoBehaviour
{
    public float lookRadius = 10f;
    private Animator animator;
    public GameObject warning;
    

    Transform target;
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        target = playerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            animator.SetBool("Aware", true);
            agent.isStopped = false;
            warning.SetActive(true);
            

        }
        else
        {
            animator.SetBool("Aware", false);
            agent.isStopped = true;
            warning.SetActive(false);
        }

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            animator.SetBool("Aware", false);
            agent.isStopped = true;
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}
