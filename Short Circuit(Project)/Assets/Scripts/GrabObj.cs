using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class GrabObj : MonoBehaviour

{

    private GvrControllerInputDevice controller;



    bool tracking = false;

    Rigidbody _Rbody;

    float dist;



    // Start is called before the first frame update 

    void Start()

    {

        controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);

        _Rbody = GetComponent<Rigidbody>();

    }



    // Update is called once per frame 

    void Update()

    {

        if (tracking)

        {

            Vector3 pos = GvrPointerInputModule.Pointer.GetPointAlongPointer(dist);

            transform.position = pos;

            if (controller.GetButtonUp(GvrControllerButton.TouchPadButton))

            {

                Debug.Log("click touch button down");

                //enable obj to repond to physic  

                _Rbody.isKinematic = false;

                // _Rbody.velocity = Vector3.forward * 2; 

                tracking = false;

            }

        }

        else

        {

            if (controller.GetButtonDown(GvrControllerButton.TouchPadButton))

            {

                Debug.Log("position" + controller.TouchPos);



                dist = GvrPointerInputModule.Pointer.CurrentRaycastResult.distance;

                transform.position = GvrPointerInputModule.Pointer.GetPointAlongPointer(dist);

                _Rbody.isKinematic = true;

                tracking = true;

            }

        }

    }

}