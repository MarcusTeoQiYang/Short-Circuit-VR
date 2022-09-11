using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourthResistor : MonoBehaviour
{

    public GameObject StartButton; //1st level canvas
    public GameObject SecondLevelButton; //button for the 2nd circuit patch
    public GameObject ThirdLevelButton; //button for the 3rd circuit patch
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
    public GameObject resistor2;
    public GameObject blackwire5; // red wire for 4th level circuit patch
    public GameObject redwire3; // red wire for 4th level circuit patch
    public GameObject Redled;
    public BoxCollider _redLEDCol;
    public BoxCollider _resistorCol;
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

    public void Resistor()
    {
        _text.text = "Which pin should it be connected to?";
        option1.SetActive(true);
        option2.SetActive(true);
        option3.SetActive(true);
        _Option1.text = "pin6";
        _Option2.text = "pin3";
        _Option3.text = "pin2";
        Redled.SetActive(false);
    }

    public void firstButton()
    {
        if (_Option1.text == "pin6")
        {
            resistor2.transform.localPosition = new Vector3(-3.7514f, -2.4274f, 4.9577f);
            greentick4.SetActive(true);
            FourthLevelButton.SetActive(true);
            _FourthLevelText.text = "Continue";
            _text.text = "Correct! Please continue";
            option1.SetActive(false);
            option2.SetActive(false);
            option3.SetActive(false);
            _resistorCol.enabled = false;
        }
    }

    public void secondButton()
    {
        if (_Option2.text == "pin3")
        {
            resistor2.transform.localPosition = new Vector3(-3.754f, -2.4274f, 4.87f);
            cross4.SetActive(true);
            _FourthLevelText.text = "Reattempt";
            FourthLevelButton.SetActive(true);
            _text.text = "Please try again";
            option3.SetActive(false);
            option2.SetActive(false);
            option1.SetActive(false);
            _resistorCol.enabled = false;
        }
    }

    public void thirdButton()
    {
        if (_Option3.text == "pin2")
        {
            resistor2.transform.localPosition = new Vector3(-3.754f, -2.4274f, 4.845f);
            cross4.SetActive(true);
            _FourthLevelText.text = "Reattempt";
            FourthLevelButton.SetActive(true);
            _text.text = "Please try again";
            option3.SetActive(false);
            option2.SetActive(false);
            option1.SetActive(false);
            _resistorCol.enabled = false;
        }
    }

    public void Next()
    {
        if (_FourthLevelText.text == "Reattempt")
        {
            resistor2.transform.localPosition = new Vector3(-3.8049f, -2.343f, 3.01f);
            cross4.SetActive(false);
            _text.text = "Which pin should it be connected to?";
            FourthLevelButton.SetActive(false);
            option1.SetActive(true);
            option2.SetActive(true);
            option3.SetActive(true);
            _resistorCol.enabled = true;
        }
        if (_FourthLevelText.text == "Continue")
        {
            greentick4.SetActive(false);
            _text.text = "Next Component";
            FourthLevelButton.SetActive(false);
            option3.SetActive(false);
            Redled.SetActive(true);
            Redled.transform.localPosition = new Vector3(-3.79f, -2.308f, 3.199f);
            _redLEDCol.enabled = true;
        }
    }
}
