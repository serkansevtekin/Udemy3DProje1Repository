using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UdemyProject1.Inputs
{

    public class DefaultInput
    {
        private DefaultActions _input;

        public bool IsForceUp { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultActions();
             _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();

            _input.Rocket.ForceUp.canceled += context => IsForceUp = false;

            _input.Enable();

        }


   

       
    }

}
