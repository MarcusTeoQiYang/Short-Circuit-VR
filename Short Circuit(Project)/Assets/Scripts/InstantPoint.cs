using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantPoint : MonoBehaviour
{
    public GameObject _bottle;
    public GameObject _solder;

    public GameObject _greenTick;

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public GameObject TextObj;
    Text _text;

    bool solderlocate = false;
    bool bottlelocate = false;

    bool TickStatus = false;
    BoxCollider _bottleCol;
    BoxCollider _solderCol;


    void Start()
    {
        _text = TextObj.GetComponent<Text>();
        _greenTick.SetActive(false);
    }
    bool DoubleClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            return true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        return false;
    }
    public void SolderBottleClick(GameObject obj)
    {
        if (DoubleClick())
        {
            if (obj.name == "Bottle")
            {
                _bottle.transform.localPosition = new Vector3(4.539378f, -2.359186f, -0.005f);
                //_bottleCol.enabled = false;
                //return;
                bottlelocate = true;
            }
            if (obj.name == "Soldering_gun (1)")
            {
                _solder.transform.localPosition = new Vector3(4.219378f, -2.623186f, 0.141f);
                //_solderCol.enabled = false;
                //return;
                solderlocate = true;
            }
            if (solderlocate == true || bottlelocate == true)
            {
                _text.text = "First item shifted!";
            }
            if (solderlocate && bottlelocate == true)
            {
                TickStatus = true;
                _text.text = "Well done!";
            }
            if (TickStatus == true)
            {
                _greenTick.SetActive(true);
            }

            }
        }



        // Start is called before the first frame update


        // Update is called once per frame
        void Update()
        {

        }
    }

