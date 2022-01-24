using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeliveryTunnel : InteractiveObj
{
    public coffee_bean_console coffeeBeanConsole;
    public GameObject tunnelExit;

    [SerializeField] GameObject UIContainer;
    [SerializeField] TextMeshProUGUI description;

    private PlayerBackpack playerBackpack;
    private StateManager state;

    public bool sentRobot;
    void Start()
    {
        playerBackpack = FindObjectOfType<PlayerBackpack>();
        state = FindObjectOfType<StateManager>();
    }

    
    void Update()
    {
        
    }

    public override void interact()
    {
        state.transitionState(State.UI);
        UIContainer.SetActive(true);
        if (playerBackpack.contains("maintenance robot") && coffeeBeanConsole.isCoverUp)
            description.text = "send maintenance robot through this tunnel";
        else
            description.text = "this is the tunnel for coffee beans";
    }

    public void exit()
    {
        UIContainer.SetActive(false);
        state.transitionState(State.Explore);
    }

    public void confirm()
    {
        if (playerBackpack.contains("maintenance robot") && coffeeBeanConsole.isCoverUp)
        {
            GameObject robot = playerBackpack.remove("maintenance robot");
            if (robot != null)
            {
                sentRobot = true;
            }
        }
        UIContainer.SetActive(false);
        state.transitionState(State.Explore);
    }
}
