using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{
    public Canvas ProximityUI;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider Entering)
    {
        if (Entering.tag == "Player")
        {
            //Debug.Log("You are inside the Safety Precaution Area");

            ProximityUI.enabled = true;

        }
    }
    void OnTriggerExit(Collider Exiting)
    {
        if (Exiting.tag == "Player")
        {
            //Debug.Log("You are exiting the Safety Precaution Area");

            ProximityUI.enabled = false;
        }
    }
}