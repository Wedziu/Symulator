using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCreator : MonoBehaviour
{
    [SerializeField] GameObject agent;
    [SerializeField] float timeBetweenSpawn = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCountDown());
    }
    IEnumerator SpawnCountDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenSpawn);
            SpawnAgent();
        }
        
    }
    void SpawnAgent()
    {
        Instantiate(agent, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
