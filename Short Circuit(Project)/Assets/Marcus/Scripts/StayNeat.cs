using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StayNeat : MonoBehaviour
{
    public GameObject _ic;
    public GameObject _solder;
    public GameObject _GreenLED;
    public GameObject _RedLED;
    public GameObject _YellowLED;
    public GameObject _GTick;
    public GameObject _RCross;
    public GameObject Countdown;

    public GameObject _BottleSolderText;

    ScoreManager sm;
    public GameObject obj;

    //bool AIStop = false;

    bool ic = false;
    bool solder = false;
    bool greenLED = false;
    bool redLED = false;
    bool yellowLED = false;

    public BoxCollider _redLEDCol;
    public BoxCollider _yellowLEDCol;
    public BoxCollider _greenLEDCol;
    public BoxCollider _solderCol;
    public BoxCollider _icCol;


    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public GameObject TextObj;
    Text _text;
    // Start is called before the first frame update
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
    void Start()
    {
        _text = TextObj.GetComponent<Text>();
        _GTick.SetActive(false);
        _RCross.SetActive(false);
        sm = obj.GetComponent<ScoreManager>();
        _BottleSolderText.SetActive(false);
        _icCol.enabled = false;
        _solderCol.enabled = false;
        _redLEDCol.enabled = false;
        _yellowLEDCol.enabled = false;
        _greenLEDCol.enabled = false;
        DeactivateAI();

    }
    public void bsButton()
    {
        _BottleSolderText.SetActive(true);
        _icCol.enabled = true;
        _solderCol.enabled = true;
        _redLEDCol.enabled = true;
        _yellowLEDCol.enabled = true;
        _greenLEDCol.enabled = true;
        ActivateAI();
    }
    public void DeactivateAI()
    {
        _GreenLED.GetComponent<AI>().enabled = false;
        _GreenLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        _YellowLED.GetComponent<AI>().enabled = false;
        _YellowLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        _RedLED.GetComponent<AI>().enabled = false;
        _RedLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        _ic.GetComponent<AI>().enabled = false;
        _ic.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        _solder.GetComponent<AI>().enabled = false;
        _solder.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
    }
    public void ActivateAI()
    {
        _GreenLED.GetComponent<AI>().enabled = true;
        _GreenLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        _YellowLED.GetComponent<AI>().enabled = true;
        _YellowLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        _RedLED.GetComponent<AI>().enabled = true;
        _RedLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        _ic.GetComponent<AI>().enabled = true;
        _ic.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        _solder.GetComponent<AI>().enabled = true;
        _solder.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
    }


    // Update is called once per frame
    public void NeatOnClick(GameObject obj)
    {
        //if (DoubleClick())
        //{
        if (obj.name == "ic_single (3)")
        {
            _ic.GetComponent<AI>().enabled = false;
            _ic.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            _ic.transform.localPosition = new Vector3(-0.54f, -1.665145f, -7.65f);
            _ic.transform.rotation = Quaternion.Euler(0, 0, 0);
            ic = true;
            _icCol.enabled = false;
        }
        if (obj.name == "Soldering_gun (2)")
        {
            _solder.GetComponent<AI>().enabled = false;
            _solder.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            _solder.transform.localPosition = new Vector3(-0.562f, -1.591f, -7.05f);
            _solder.transform.rotation = Quaternion.Euler(0, 270, 0);
            solder = true;
            _solderCol.enabled = false;
        }
        if (obj.name == "GreenLED (1)")
        {
            _GreenLED.GetComponent<AI>().enabled = false;
            _GreenLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            _GreenLED.transform.localPosition = new Vector3(-0.12f, -1.493f, -7.232f);
            _GreenLED.transform.rotation = Quaternion.Euler(0f, 180, 75f);
            greenLED = true;
            _greenLEDCol.enabled = false;
        }
        if (obj.name == "YellowLED (1)")
        {
            _YellowLED.GetComponent<AI>().enabled = false;
            _YellowLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            _YellowLED.transform.localPosition = new Vector3(-0.546f, -1.488f, -7.232f);
            _YellowLED.transform.rotation = Quaternion.Euler(0, 180, 75);
            yellowLED = true;
            _yellowLEDCol.enabled = false;
        }
        if (obj.name == "RedLED (1)")
        {
            _RedLED.GetComponent<AI>().enabled = false;
            _RedLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            _RedLED.transform.localPosition = new Vector3(-1.042f, -1.48f, -7.236f);
            _RedLED.transform.rotation = Quaternion.Euler(0, 180, 75);
            redLED = true;
            _redLEDCol.enabled = false;
        }
        // if (redLED || yellowLED || solder || ic || greenLED == true)
        // {
        //    _text.text = "Four to go!";
        //}
        if (redLED && yellowLED && solder && ic && greenLED == true)
        {
            _GTick.SetActive(true);
            _text.text = "Nice and neat!";
            sm.AddedPoint(1);
            Countdown.GetComponent<Countdown1>().enabled = false;
            //}
        }
    }
}
