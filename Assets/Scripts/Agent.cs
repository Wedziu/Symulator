using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Agent : MonoBehaviour
{
   [SerializeField] Vector3 newPosition;
    [SerializeField] public float health = 3;
    NavMeshAgent agentAI;
    // Start is called before the first frame update
    void Start()
    {
        agentAI = GetComponent<NavMeshAgent>();
        NewPosition();
        MoveToNewPosition();
    }
    void LateUpdate()
    {
        CheckPosition();
        AgentDestroy();
    }
    void CheckPosition()
    {

        if (agentAI.transform.position != newPosition) return;
        MoveToNewPosition();
        
    }

    private void NewPosition()
    {
        newPosition = new Vector3(Random.Range(-19, 19), 1.04f, Random.Range(-19f, 19f));
    }

    private void MoveToNewPosition()
    {
        NewPosition();
        agentAI.SetDestination(newPosition);
        //if (agentAI.transform.position != newPosition) return;
            
    }

    private void OnTriggerEnter(Collider other)
    {
        health--;
        Debug.Log("I Hit something!");
        GetComponent<AudioSource>().Play();
    }
    

    void AgentDestroy()
    {
        if(health<=0)
        {
            Debug.Log("I'm dead!");
            Destroy(gameObject);
        }
    }
}
