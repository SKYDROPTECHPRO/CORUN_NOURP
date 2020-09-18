using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))] // TODO: remove after testing
[RequireComponent(typeof(PlayerMotor))]
public class PlayerDriver : MonoBehaviour
{
    private A_InputHandler input;
    private PlayerMotor motor;
    //[Range(-1,1)]public float horizontalinput; // TODO: remove testing

    private void Start()
    {
        input = GetComponent<A_InputHandler>();
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        motor.Moveplayer(input.getinput());
    }
}
