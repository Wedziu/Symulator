using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Agent : MonoBehaviour
{
   [SerializeField] Vector3 newPosition;
    NavMeshAgent agentAI;
    // Start is called before the first frame update
    void Start()
    {
        agentAI = GetComponent<NavMeshAgent>();
        NewPosition();
        MoveToNewPosition();
    }
    void CheckPosition()
    {

        if (agentAI.transform.position != newPosition) return;
        MoveToNewPosition();
        Debug.Log("CheckPosition");
    }

    private void NewPosition()
    {
        newPosition = new Vector3(Random.Range(-29, 29), 1.04f, Random.Range(-29f, 29f));
    }

    private void MoveToNewPosition()
    {
        NewPosition();
        agentAI.SetDestination(newPosition);
        //if (agentAI.transform.position != newPosition) return;
            
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CheckPosition();
    }
}
