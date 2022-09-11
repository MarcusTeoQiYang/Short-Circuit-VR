using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipperAnim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    
    
    public void animActive(bool enabled)
    {

    }
}
