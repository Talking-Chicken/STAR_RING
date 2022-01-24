using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_console : InteractiveObj
{
    public GameObject robot;

    [SerializeField] DeliveryTunnel tunnel;
    public override void interact()
    {
        if (tunnel.sentRobot)
            robot.SetActive(true);
    }
}