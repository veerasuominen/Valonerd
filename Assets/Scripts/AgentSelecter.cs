using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class AgentSelecter : MonoBehaviour
{
    [SerializeField] private GameObject astra;
    [SerializeField] private GameObject omen;
    [SerializeField] private GameObject brimstone;
    [SerializeField] private GameObject harbod;
    [SerializeField] private GameObject clove;
    [SerializeField] private GameObject viper;
    [SerializeField] private int selectedAgent;

    [SerializeField] private TextMeshProUGUI output;

    // Exposes an float array in the inspector, which you can edit there.
    public List<string> agents = new List<string>();

    private void Start()
    {
        //Selects a random agent from the list
        int agent = UnityEngine.Random.Range(0, agents.Count);

        selectedAgent = agent;

        Debug.Log(agents[agent]);

        if (agents[agent] == "Astra") { astra.SetActive(true); }

        if (agents[agent] == "Brimstone") { brimstone.SetActive(true); }

        if (agents[agent] == "Omen") { omen.SetActive(true); }

        if (agents[agent] == "Harbor") { harbod.SetActive(true); }

        if (agents[agent] == "Clove") { clove.SetActive(true); }

        if (agents[agent] == "Viper") { viper.SetActive(true); }
    }

    public void HandleInputData(int val)
    {
        if (val != selectedAgent)
        {
            output.text = "wrong";
        }

        if (val == selectedAgent)
        {
            output.text = "true";
        }
    }
}