using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UdemyProject1.Inputs
{

    public class DefaultInput
    {
        private DefaultActions _input;

        public bool IsForceUp { get; private set; }
        
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultActions();

            //Rocket Up
            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();

            _input.Rocket.ForceUp.canceled += context => IsForceUp = false;

            //Rocket righit and left
            _input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();
           


            _input.Enable();

        }


   

       
    }

}
