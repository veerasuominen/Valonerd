using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySelecter : MonoBehaviour
{
    [SerializeField] private GameObject astra, brimstone, omen, harbor, clove, viper;
    [SerializeField] private GameObject dropdownmenu;
    [SerializeField] private GameObject astraAbilityMenu, brimstoneAbilityMenu, omenAbilityMenu, harborAbilityMenu, cloveAbilityMenu, viperAbilityMenu;
    [SerializeField] private GameObject astraBlock, brimBlock, omenBlock, harborBlock, cloveBlock, viperBlock;

    [SerializeField] private int selectedAgent;

    [SerializeField] private TextMeshProUGUI output;

    // Exposes an float array in the inspector, which you can edit there.
    public List<string> agents = new List<string>();

    private void Start()
    {
        //Selects a random agent from the list
        int agent = Random.Range(1, agents.Count);

        selectedAgent = agent;

        //prints the selected agent in debug log
        Debug.Log(selectedAgent);

        //sets the right ability sprite active
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
            output.text = "Wrong agent!";
            Debug.Log("Wrong agent!");

            if (selectedAgent == 1)
            {
                astraBlock.SetActive(false);
            }

            if (selectedAgent == 2)
            {
                brimBlock.SetActive(false);
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
            if (selectedAgent == 2)
            {
                viperBlock.SetActive(false);
            }
        }

        if (val == selectedAgent)
        {
            output.text = "Right agent!";
            dropdownmenu.SetActive(false);

            //sets the right set of buttons active based on agent selected
            if (selectedAgent == 1)
            {
                astraAbilityMenu.SetActive(true);

                if (val == selectedAgent)
                {
                    astraBlock.SetActive(false);
                }
            }

            if (selectedAgent == 2)
            {
                brimstoneAbilityMenu.SetActive(true);

                if (val == selectedAgent)
                {
                    brimBlock.SetActive(false);
                }
            }

            if (selectedAgent == 3)
            {
                omenAbilityMenu.SetActive(true);

                if (val == selectedAgent)
                {
                    omenBlock.SetActive(false);
                }
            }

            if (selectedAgent == 4)
            {
                harborAbilityMenu.SetActive(true);

                if (val == selectedAgent)
                {
                    harborBlock.SetActive(false);
                }
            }

            if (selectedAgent == 5)
            {
                cloveAbilityMenu.SetActive(true);

                if (val == selectedAgent)
                {
                    cloveBlock.SetActive(false);
                }
            }

            if (selectedAgent == 6)
            {
                viperAbilityMenu.SetActive(true);

                if (val == selectedAgent)
                {
                    viperBlock.SetActive(false);
                }
            }
        }
    }

    public void Incorrect()
    {
        output.text = "Try again!";
    }

    public void Correct()
    {
        output.text = "Correct!";
        if (selectedAgent == 1) { astraAbilityMenu.SetActive(false); }

        if (selectedAgent == 2) { brimstoneAbilityMenu.SetActive(false); }

        if (selectedAgent == 3) { omenAbilityMenu.SetActive(false); }

        if (selectedAgent == 4) { harborAbilityMenu.SetActive(false); }

        if (selectedAgent == 5) { cloveAbilityMenu.SetActive(false); }

        if (selectedAgent == 6) { viperAbilityMenu.SetActive(false); }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
    }
}