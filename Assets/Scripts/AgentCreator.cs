using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCreator : MonoBehaviour
{
    [SerializeField] GameObject agent;
    [SerializeField] float timeBetweenSpawn = 3;
    [SerializeField] float numberOfAgents;
    [SerializeField] float maxAgentsNumber = 30;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCountDown());
    }
    IEnumerator SpawnCountDown()
    {
        numberOfAgents = FindObjectsOfType<Agent>().Length;
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenSpawn);
            SpawnAgent();

        }
    }
    void SpawnAgent()
    {
        if (numberOfAgents <= maxAgentsNumber - 1)
        {
            
            var newAgent = Instantiate(agent, transform.position, transform.rotation);
            newAgent.name = ("Agent " + FindObjectsOfType<Agent>().Length);
            newAgent.transform.parent = gameObject.transform;
            Debug.Log(numberOfAgents);

            Debug.Log("I Spawned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        numberOfAgents = FindObjectsOfType<Agent>().Length;
    }
}
