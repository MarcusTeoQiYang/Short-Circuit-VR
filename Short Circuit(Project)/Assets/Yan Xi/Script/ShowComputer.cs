using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowComputer : MonoBehaviour
{
    public Canvas ProximityUI2;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider Entering)
    {
        if (Entering.tag == "Player")
        {
            //Debug.Log("You are inside the Computer Area");

            ProximityUI2.enabled = true;
        }
    }

    void OnTriggerExit(Collider Exiting)
    {
        if (Exiting.tag == "Player")
        {
            //Debug.Log("You are exitin the Computer Area");

            ProximityUI2.enabled = false;
        }
    }
}
