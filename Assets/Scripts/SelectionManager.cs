using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SelectionManager : MonoBehaviour
{
    [SerializeField] Material selectedMaterial;
    [SerializeField] Material defaultMaterial;
    [SerializeField] TextMeshProUGUI currentNumberOfAgents;
    [SerializeField] TextMeshProUGUI nameOfAgent;
    [SerializeField] TextMeshProUGUI health;
    Transform _selection;
    

    private void Start()
    {
        nameOfAgent.text = ("No Agent Selected");
        health.text = ("No Agent Selected");
        currentNumberOfAgents.text = ("No Agents on map");
    }
    void Update()
    {
        SelectAnAgent();
        currentNumberOfAgents.text = ("Current number of Agents - " + FindObjectsOfType<Agent>().Length);
    }

    private void SelectAnAgent()
    {
        if (_selection != null && Input.GetMouseButtonDown(1) )
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            

            _selection = null;
            nameOfAgent.text = ("No Agent Selected");
            health.text = ("No Agent Selected");
        }



        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (hit.transform.tag != "Respawn")
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                {
                    if (selectionRenderer != null )
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            selectionRenderer.material = selectedMaterial;
                            nameOfAgent.text = hit.transform.name;
                            health.text = ("Health = " + hit.transform.GetComponent<Agent>().health.ToString());
                        }
                    }
                    _selection = selection;
                }
            }
        }
    }

    public void ClearAllAgentsMaterial()
    {
        var agent = FindObjectsOfType<Agent>();
        foreach (var agents in agent)
        {
            agents.GetComponent<MeshRenderer>().material = defaultMaterial;
            nameOfAgent.text = ("No Agent Selected");
            health.text = ("No Agent Selected");
        }
    }

}