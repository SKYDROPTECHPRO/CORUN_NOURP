using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))] // TODO: remove after testing
[RequireComponent(typeof(PlayerMotor))]
[RequireComponent(typeof(PlayerPower))]
public class PlayerDriver : MonoBehaviour
{
    private A_InputHandler _input;
    private PlayerMotor _motor;
    private PlayerPower _power;
    //[Range(-1,1)]public float horizontalinput; // TODO: remove testing

    private void Start()
    {
        _input = GetComponent<A_InputHandler>();
        _motor = GetComponent<PlayerMotor>();
        _power = GetComponent<PlayerPower>();
        _power.changeplayer(0);
    }

    private void Update()
    {
        _motor.Moveplayer(_input.getinput());

        #region Change model test

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _power.changeplayer(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _power.changeplayer(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _power.changeplayer(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _power.changeplayer(3);
        }

        #endregion
    }
}
