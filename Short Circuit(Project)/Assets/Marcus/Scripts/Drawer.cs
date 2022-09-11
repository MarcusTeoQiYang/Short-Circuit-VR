using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public Animator anim;
    public Animator DrawerLeft;
    public Animator Cabinet;
    public Animator Drawer2R;
    public Animator Drawer2L;
    //bool DrawerStatus = false;
    // Start is called before the first frame update

    public void DrawerRightOpen()
    {
        if (anim.GetBool("Open"))
            anim.SetBool("Open", false);
        else anim.SetBool("Open", true);
    }
    public void DrawerLeftOpen()
    {
        if (DrawerLeft.GetBool("Open"))
            DrawerLeft.SetBool("Open", false);
        else DrawerLeft.SetBool("Open", true);
    }
    public void CabinetDoorOpen()
    {
        if (Cabinet.GetBool("Open"))
            Cabinet.SetBool("Open", false);
        else Cabinet.SetBool("Open", true);
    }
    public void Drawer2RightOpen()
    {
        if (Drawer2R.GetBool("Open"))
            Drawer2R.SetBool("Open", false);
        else Drawer2R.SetBool("Open", true);
    }
    public void Drawer2LeftOpen()
    {
        if (Drawer2L.GetBool("Open"))
            Drawer2L.SetBool("Open", false);
        else Drawer2L.SetBool("Open", true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
