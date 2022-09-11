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

    bool ic = false;
    bool solder = false;
    bool greenLED = false;
    bool redLED = false;
    bool yellowLED = false;

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
    }

    // Update is called once per frame
    public void NeatOnClick(GameObject obj)
    {
        if (DoubleClick())
        {
            if (obj.name == "ic_single (3)")
            {
                _ic.transform.localPosition = new Vector3(4.351f, -2.584186f, -2.323f);
                _ic.transform.rotation = Quaternion.Euler(0, 0, 0);
                ic = true;
            }
            if (obj.name == "Soldering_gun (2)")
            {
                _solder.transform.localPosition = new Vector3(4.239f, -2.629186f, -2.08f);
                _solder.transform.rotation = Quaternion.Euler(0, 270, 0);
                solder = true;
            }
            if (obj.name == "GreenLED (1)")
            {
                _GreenLED.transform.localPosition = new Vector3(4.2944f, -2.4904f, -2.13f);
                _GreenLED.transform.rotation = Quaternion.Euler(-0.739f, 180, 75.674f);
                greenLED = true;
            }
            if (obj.name == "YellowLED (1)")
            {
                _YellowLED.transform.localPosition = new Vector3(4.488f, -2.4904f, -2.134f);
                _YellowLED.transform.rotation = Quaternion.Euler(0, 180, 75);
                yellowLED = true;
            }
            if (obj.name == "RedLED (1)")
            {
                _RedLED.transform.localPosition = new Vector3(4.064f, -2.473f, -2.128f);
                _RedLED.transform.rotation = Quaternion.Euler(0, 180, 75);
                redLED = true;
            }
           // if (redLED || yellowLED || solder || ic || greenLED == true)
           // {
            //    _text.text = "Four to go!";
            //}
            if (redLED && yellowLED && solder && ic && greenLED== true)
            {
                _GTick.SetActive(true);
                _text.text = "Nice and clean!";
            }

        }
        void Update()
        {

        }
    }
}
