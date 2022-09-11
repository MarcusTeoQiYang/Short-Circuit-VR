using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPatch : MonoBehaviour
{
    public Canvas ProximityUI1;
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider Entering)
    {
        if(Entering.tag == "Player")
        {
            //Debug.Log("You are inside the Circuit Patching Area");

            ProximityUI1.enabled = true;
        }
    }

    void OnTriggerExit(Collider Exiting)
    {
        if(Exiting.tag == "Player")
        {
            //Debug.Log("You are exitin the Circuit Patching Area");

            ProximityUI1.enabled = false;
        }
    }
}
