using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTrigerStay(Collider other)
    {
        if(other.tag == "Door")
        {
            Animator anime = other.GetComponentInChildren<Animator>();
            if(Input.GetKeyDown(KeyCode.E))
            anime.SetTrigger("OpenClose");
        }
    }
}
