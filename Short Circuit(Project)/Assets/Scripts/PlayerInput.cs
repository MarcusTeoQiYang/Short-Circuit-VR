using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour

{

    private GvrControllerInputDevice controller;

    public GameObject obj;//use in 2-3 



    // Start is called before the first frame update 

    void Start()

    {

        controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);

    }



    // Update is called once per frame 

    void Update()

    {

        if (controller.GetButtonUp(GvrControllerButton.TouchPadButton))

        {

            Debug.Log("click touch button down");



        }



        if (controller.GetButtonDown(GvrControllerButton.App))

        {

            Debug.Log("click App button down");



        }

        if (controller.GetButton(GvrControllerButton.TouchPadTouch))

        {

            Debug.Log("position" + controller.TouchPos);



        }

    }
}