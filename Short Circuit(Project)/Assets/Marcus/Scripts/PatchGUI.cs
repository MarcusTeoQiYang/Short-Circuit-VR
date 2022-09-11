using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatchGUI : MonoBehaviour
{
    public GameObject GUIlvl1;
    public GameObject GUIlvl1Correct;
    public GameObject GUIlvl2;
    public GameObject GUIlvl2Correct;
    public GameObject GUIlvl3;
    public GameObject GUIlvl3Correct;
    public GameObject GUIlvl4;

    public GameObject Incorrect;

    Text _text;
    Text _StartButtonText;
    Text _Option1;
    Text _Option2;
    Text _Option3;
    Text _SecondLvlButtonText;
    Text _ThirdLvlButtonText;
    Text _FourthLvlButtonText;

    public GameObject Option2;
    public GameObject Option1;
    public GameObject Option3;

    public GameObject Description;
    public GameObject StartButtonText;
    public GameObject SecondLvlButtonText;
    public GameObject ThirdLvlButtonText;
    public GameObject FourthLvlButtonText;
    // Start is called before the first frame update
    void Start()
    {
        GUIlvl1.SetActive(false);
        GUIlvl2.SetActive(false);
        GUIlvl2Correct.SetActive(false);
        Incorrect.SetActive(false);
        _text = Description.GetComponent<Text>();
        _StartButtonText = StartButtonText.GetComponent<Text>();
        _Option2 = Option2.GetComponent<Text>();
        _Option1 = Option1.GetComponent<Text>();
        _Option3 = Option3.GetComponent<Text>();
        _SecondLvlButtonText = SecondLvlButtonText.GetComponent<Text>();
        _ThirdLvlButtonText = ThirdLvlButtonText.GetComponent<Text>();
        _FourthLvlButtonText = FourthLvlButtonText.GetComponent<Text>();
    }

    public void StartButton()
    {
        GUIlvl1.SetActive(true);
        _text.text = "Assuming a power supply is connected to the breadboard, which LED should be connected to the highlighted part of the breadboard for it to light up?";
        if (_StartButtonText.text == "Continue")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(true);
            GUIlvl1Correct.SetActive(false);
            _text.text = "Assuming a power supply is connected to the breadboard, where will the wire be connected for pin 7 of the IC chip? VCC or GND";
        }
        if (_SecondLvlButtonText.text == "Continue")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(true);
            _text.text = "Take a look at this circuit, will the LED light up when connected to a power supply?";
        }
        if (_ThirdLvlButtonText.text == "Continue")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(true);
            _text.text = "Patch up the circuit accordingly to the circuit in the image above";
        }
        if (_StartButtonText.text == "Retry")
        {
            Incorrect.SetActive(false);
        }
        if (_SecondLvlButtonText.text == "Retry")
        {
            Incorrect.SetActive(false);
        }
        if(_ThirdLvlButtonText.text == "Retry")
        {
            Incorrect.SetActive(false);
        }
        if (_FourthLvlButtonText.text == "Retry")
        {
            Incorrect.SetActive(false);
        }
        if (_FourthLvlButtonText.text == "retry")
        {
            Incorrect.SetActive(false);
        }
        if (_FourthLvlButtonText.text == "Reattempt")
        {
            Incorrect.SetActive(false);
        }
        if (_FourthLvlButtonText.text == "Retry ")
        {
            Incorrect.SetActive(false);
        }
    }
    public void OptionOneText()
    {
        if (_Option1.text == "True")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(true);
            _text.text = "Thats right! The circuit is connected from VCC to GND!";
        }
        if (_Option1.text == "1")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option1.text == "+")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option1.text == "Pin1")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option1.text == "pin7")
        {
            _text.text = "Thats Right! The Black wire should be connected at PIN 7 to VCC.";
        }
        if (_Option1.text == "pin6")
        {
            _text.text = "Thats Right! The resistor should be connected at PIN 6 according to the image.";
        }
        if (_Option1.text == "Correct")
        {
            _text.text = "Thats Right! Successfully patched the circuit!";
        }
    }
    public void OptionTwoText()
    {
        if (_Option2.text == "2")
        {
            GUIlvl1Correct.SetActive(true);
            GUIlvl1.SetActive(false);
            _text.text = "Thats right! Cathode(-) has to be connected to GND while Anode(+) has to be connected to VCC.";
        }
        if (_Option2.text == "-")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl2Correct.SetActive(true);
            _text.text = "That's right! PIN 7 of the IC chip has to be connected to GND!";
        }
        if (_Option2.text == "False")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option2.text == "Pin14")
        {
            _text.text = "Thats Right! The Red wire should be connected at PIN 14 to VCC.";
        }
        if (_Option2.text == "pin4")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option2.text == "pin3")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option2.text == "Incorrect")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
    }
    public void OptionThreeText()
    {
        if (_Option3.text == "Pin7")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option3.text == "pin10")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
        if (_Option3.text == "pin2")
        {
            GUIlvl1.SetActive(false);
            GUIlvl2.SetActive(false);
            GUIlvl1Correct.SetActive(false);
            GUIlvl2Correct.SetActive(false);
            GUIlvl3.SetActive(false);
            GUIlvl3Correct.SetActive(false);
            GUIlvl4.SetActive(false);
            Incorrect.SetActive(true);
            _text.text = "Thats incorrect! Try again.";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
