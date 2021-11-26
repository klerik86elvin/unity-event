using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMeshManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        float dist = Vector3.Distance(transform.position, playerTransform.position);

        if(dist < 15)
        {
            agent.SetDestination(playerTransform.position);
            GetComponent<EnemyAnimation>().Run();
        }
        if(dist < 3)
        {
            GetComponent<EnemyAnimation>().Attack();
        }
    }
}
