using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourthPatchBlackWire : MonoBehaviour
{
    public GameObject StartButton; //1st level canvas
    public GameObject SecondLevelButton; //button for the 2nd circuit patch
    public GameObject ThirdLevelButton; //button for the 3rd circuit patch
    public GameObject blackwire5; // red wire for 4th level circuit patch
    public GameObject option1; //user option
    public GameObject option2; //user option
    public GameObject option3; //user option
    public GameObject Option1; //text from the option 1 canvas button
    public GameObject Option2; //text from the option 2 canvas button
    public GameObject Option3; //text from the option 3 canvas button
    public GameObject ResultText; //text from the result canvas
    public GameObject cross4; // cross image for 3nd circuit patch
    public GameObject greentick4;
    public GameObject FourthLevelButton; //button for the 4th circuit patch
    public GameObject fourthLvlText; // text of the 4th level button
    public GameObject redwire3; // red wire for 4th level circuit patch
    public GameObject resistor2;
    public GameObject Redled;
    public BoxCollider _resistorCol;
    public BoxCollider _blackWireCol;
    Text _Option1;
    Text _Option2;
    Text _Option3;
    Text _text;
    Text _FourthLevelText;


    void Start()
    {
        _Option1 = Option1.GetComponent<Text>();
        _Option2 = Option2.GetComponent<Text>();
        _Option3 = Option3.GetComponent<Text>();
        _FourthLevelText = fourthLvlText.GetComponent<Text>();
        _text = ResultText.GetComponent<Text>(); //obtain text from the result canvas
        greentick4.SetActive(false);
        cross4.SetActive(false);

    }

    public void Blackwire()
    {
        _text.text = "Which pin should it be connected for GND";
        option1.SetActive(true);
        option2.SetActive(true);
        option3.SetActive(true);
        _Option1.text = "pin7";
        _Option2.text = "pin4";
        _Option3.text = "pin10";
        resistor2.SetActive(false);
        Redled.SetActive(false);
    }

    public void firstButton()
    {
        if (_Option1.text == "pin7")
        {
            blackwire5.transform.localPosition = new Vector3(-3.6633f, -2.4254f, 5.0056f);
            greentick4.SetActive(true);
            FourthLevelButton.SetActive(true);
            _FourthLevelText.text = "Proceed";
            _text.text = "Correct! Please continue";
            option1.SetActive(false);
            option2.SetActive(false);
            option3.SetActive(false);
            _blackWireCol.enabled = false;
        }
    }

    public void secondButton()
    {
        if (_Option2.text == "pin4")
        {
            blackwire5.transform.localPosition = new Vector3(-3.6633f, -2.4254f, 4.9245f);
            cross4.SetActive(true);
            _FourthLevelText.text = "retry";
            _text.text = "Please try again";
            FourthLevelButton.SetActive(true);
            option3.SetActive(false);
            option2.SetActive(false);
            option1.SetActive(false);
            _blackWireCol.enabled = false;
        }
    }

    public void thirdButton()
    {
        if (_Option3.text == "pin10")
        {  
            cross4.SetActive(true);
            _FourthLevelText.text = "retry";
            blackwire5.transform.localPosition = new Vector3(-4.011f, -2.4254f, 4.9483f);
            _text.text = "Please try again";
            FourthLevelButton.SetActive(true);
            option3.SetActive(false);
            option2.SetActive(false);
            option1.SetActive(false);
            _blackWireCol.enabled = false;
        }
    }

    public void Next()
    {
        if (_FourthLevelText.text == "retry")
        {
            cross4.SetActive(false);
            _text.text = "Which pin should it be connected for VCC";
            FourthLevelButton.SetActive(false);
            option1.SetActive(true);
            option2.SetActive(true);
            option3.SetActive(true);
            blackwire5.transform.localPosition = new Vector3(-3.8049f, -2.343f, 2.861f);
            _blackWireCol.enabled = true;
            //blackwire5.SetActive(true);
            //resistor2.SetActive(true);
            //Redled.SetActive(true);
            //redwire3.SetActive(true);
        }
        if (_FourthLevelText.text == "Proceed")
        {
            greentick4.SetActive(false);
            _text.text = "Next Component";
            FourthLevelButton.SetActive(false);
            resistor2.SetActive(true);
            resistor2.transform.localPosition = new Vector3(-3.8049f, -2.343f, 3.01f);
            Redled.SetActive(false);
            _resistorCol.enabled = true; 
}
    }
}
