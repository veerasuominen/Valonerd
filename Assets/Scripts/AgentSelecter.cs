using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class AgentSelecter : MonoBehaviour
{
    [SerializeField] private GameObject astra, brimstone, omen, harbor, clove, viper;
    [SerializeField] private GameObject astraBlock, brimstoneBlock, omenBlock, harborBlock, cloveBlock, viperBlock;
    [SerializeField] private GameObject dropdownmenu;
    [SerializeField] private int selectedAgent;
    [SerializeField] private TextMeshProUGUI output;

    // Exposes an float array in the inspector, which you can edit there.
    public List<string> agents = new List<string>();

    private void Start()
    {
        //Selects a random agent from the list
        int agent = UnityEngine.Random.Range(1, agents.Count);

        selectedAgent = agent;

        Debug.Log(selectedAgent);

        if (selectedAgent == 1) { astra.SetActive(true); }

        if (selectedAgent == 2) { brimstone.SetActive(true); }

        if (selectedAgent == 3) { omen.SetActive(true); }

        if (selectedAgent == 4) { harbor.SetActive(true); }

        if (selectedAgent == 5) { clove.SetActive(true); }

        if (selectedAgent == 6) { viper.SetActive(true); }
    }

    public void HandleInputData(int val)
    {
        if (val != selectedAgent)
        {
            output.text = "Incorrect!";

            if (selectedAgent == 1)
            {
                astraBlock.SetActive(false);
            }

            if (selectedAgent == 2)
            {
                brimstoneBlock.SetActive(false);
            }
            if (selectedAgent == 3)
            {
                omenBlock.SetActive(false);
            }
            if (selectedAgent == 4)
            {
                harborBlock.SetActive(false);
            }
            if (selectedAgent == 5)
            {
                cloveBlock.SetActive(false);
            }
            if (selectedAgent == 6)
            {
                brimstoneBlock.SetActive(false);
            }
        }

        if (val == selectedAgent)
        {
            output.text = "Correct!";
            dropdownmenu.SetActive(false);

            if (selectedAgent == 1)
            {
                astraBlock.SetActive(false);
            }

            if (selectedAgent == 2)
            {
                brimstoneBlock.SetActive(false);
            }
            if (selectedAgent == 3)
            {
                omenBlock.SetActive(false);
            }
            if (selectedAgent == 4)
            {
                harborBlock.SetActive(false);
            }
            if (selectedAgent == 5)
            {
                cloveBlock.SetActive(false);
            }
            if (selectedAgent == 6)
            {
                brimstoneBlock.SetActive(false);
            }
        }
    }
}