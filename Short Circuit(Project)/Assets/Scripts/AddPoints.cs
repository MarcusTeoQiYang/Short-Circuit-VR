using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
     bool pointStatus = false;
     bool solderlocate = false;
     bool bottlelocate = false;

    public delegate void Added(int pointAmt);//declaration 
    public static event Added AddingPoints;//an event of this type 
    // Start is called before the first frame update
    void Start()
    {
        solderlocate = false;
        bottlelocate = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
            //AddingPoints(1);//trigger the event 
    }
    public void clickPoint()
    {
        //if (!pointStatus)
        //{
            AddingPoints(1);
            //pointStatus = true;
        //}
    }
    public void solderbottlepoint()
    {
        if (solderlocate && bottlelocate == true)
        {
            AddingPoints(1);
        }
    }
}
