using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColor : MonoBehaviour
{
    MeshRenderer rend;
    Color defaultcolor;
    // Start is called before the first frame update
    void Start()
    {
       rend = GetComponent<MeshRenderer>();
       defaultcolor = rend.material.GetColor("_Color");

    }
    public void highlight(bool enable)
    {
        if (enable)
        {
            rend.material.SetColor("_Color", Color.cyan);

        }
        else
            rend.material.SetColor("_Color", defaultcolor);

    }
}
