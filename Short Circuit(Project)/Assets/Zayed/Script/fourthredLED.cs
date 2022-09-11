using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourthredLED : MonoBehaviour
{
    public GameObject Redled;
    public GameObject blackwire6;
    public GameObject option1; //user option
    public GameObject option2; //user option
    public GameObject option3; //user option
    public GameObject Option1; //text from the option 1 canvas button
    public GameObject Option2; //text from the option 2 canvas button
    public GameObject ResultText; //text from the result canvas
    public GameObject FourthLevelButton; //button for the 4th circuit patch
    public GameObject fourthLvlText; // text of the 4th level button
    public GameObject Redbulb;
    public GameObject cross4;
    public GameObject tick4;
    public GameObject blackwire5; // red wire for 4th level circuit patch
    public GameObject redwire3; // red wire for 4th level circuit patch
    public GameObject resistor2;
    Text _Option1;
    Text _Option2;
    Text _text;
    Text _FourthLevelText;
    public BoxCollider _redLEDCol;
    public GameObject Controller;
    ScoreManager sm;

    void Start()
    {
        sm = Controller.GetComponent<ScoreManager>();
        _Option1 = Option1.GetComponent<Text>();
        _Option2 = Option2.GetComponent<Text>();
        _FourthLevelText = fourthLvlText.GetComponent<Text>();
        _text = ResultText.GetComponent<Text>(); //obtain text from the result canvas
    }

    public void redLED()
    {
        Redled.transform.localPosition = new Vector3(-3.727f, -2.3199f, 4.853f);
        Redled.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        blackwire6.transform.localPosition = new Vector3(-3.643f, -2.433f, 4.837f);
        option1.SetActive(true);
        option2.SetActive(true);
        option3.SetActive(false);
        _Option1.text = "Correct";
        _Option1.fontSize = 40;
        _Option2.text = "Incorrect";
        _Option2.fontSize = 40;
        _text.text = "Is the Red LED connected correctly?";

    }

    public void firstButton()
    {
        if (_Option1.text == "Correct")
        {
            Redled.transform.localPosition = new Vector3(-3.727f, -2.3199f, 4.853f);
            Redled.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            //_FourthLevelText.text = "Congratulations";
            _text.text = "You have successfully connected the circuit";
            option1.SetActive(false);
            option2.SetActive(false);
            tick4.SetActive(true);
            Redbulb.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            sm.AddedPoint(1);
            _redLEDCol.enabled = false;
        }
    }

    public void secondButton()
    {
        if (_Option2.text == "Incorrect")
        {
            _FourthLevelText.text = "Retry ";
            _text.text = "Please try again";
            option1.SetActive(false);
            option2.SetActive(false);
            FourthLevelButton.SetActive(true);
            cross4.SetActive(true);
            _redLEDCol.enabled = false;
        }
    }

    public void Next()
    {
        if (_FourthLevelText.text == "Retry ")
        {
            _text.text = "Which pin should it be connected to?";
            FourthLevelButton.SetActive(false);
            option1.SetActive(true);
            option2.SetActive(true);
            option3.SetActive(false);
            cross4.SetActive(false);
            //Redled.transform.localPosition = new Vector3(-3.727f, -2.308f, 3.199f);
            Redbulb.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            //blackwire5.SetActive(true);
            //resistor2.SetActive(true);
            //Redled.SetActive(true);
            //redwire3.SetActive(true);
            Redled.transform.localPosition = new Vector3(-3.79f, -2.308f, 3.199f);
            _redLEDCol.enabled = true;
        }
    }
}
