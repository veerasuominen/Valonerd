using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AbilitySelecter : MonoBehaviour
{
    [SerializeField] private GameObject astra, omen, brimstone, harbor, clove, viper;
    [SerializeField] private GameObject dropdownmenu;
    [SerializeField] private GameObject astraAbilityMenu;
    [SerializeField] private int selectedAgent;
    [SerializeField] private string agentString;
    [SerializeField] private TextMeshProUGUI output;

    // Exposes an float array in the inspector, which you can edit there.
    public List<string> agents = new List<string>();

    private void Start()
    {
        //Selects a random agent from the list
        int agent = Random.Range(0, agents.Count);

        selectedAgent = agent;

        Debug.Log(selectedAgent);

        if (selectedAgent == 0) { astra.SetActive(true); }

        if (selectedAgent == 1) { brimstone.SetActive(true); }

        if (selectedAgent == 2) { omen.SetActive(true); }

        if (selectedAgent == 3) { harbor.SetActive(true); }

        if (selectedAgent == 4) { clove.SetActive(true); }

        if (selectedAgent == 5) { viper.SetActive(true); }
    }

    public void HandleInputData(int val)
    {
        if (val != selectedAgent)
        {
            output.text = "Incorrect!";
        }

        if (val == selectedAgent)
        {
            output.text = "Correct!";
            //dropdownmenu.SetActive(false);

            //agentString = selectedAgent.ToString();
            GameObject.Find(selectedAgent.ToString()).SetActive(true);
        }
    }
}