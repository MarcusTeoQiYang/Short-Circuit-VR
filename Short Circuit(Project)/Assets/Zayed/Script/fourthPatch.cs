using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourthPatch : MonoBehaviour
{
    public GameObject StartButton; //1st level canvas
    public GameObject SecondLevelButton; //button for the 2nd circuit patch
    public GameObject ThirdLevelButton; //button for the 3rd circuit patch
    public GameObject redwire3; // red wire for 4th level circuit patch
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
    public GameObject blackwire5;
    public GameObject resistor2;
    public GameObject Redled;

    public BoxCollider _redWireCol;
    public BoxCollider _blackWireCol;
    public BoxCollider _resistorCol;
    public BoxCollider _redLEDCol;

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

    // Update is called once per frame
    public void redwire()
    {
        _text.text = "Where do you want to connect it to?";
        option1.SetActive(true);
        option2.SetActive(true);
        option3.SetActive(true);
        _Option1.text = "Pin1";
        _Option2.text = "Pin14";
        _Option3.text = "Pin7";

        blackwire5.SetActive(false);
        resistor2.SetActive(false);
        Redled.SetActive(false);
    }

    public void firstButton()
    {
        if (_Option1.text == "Pin1")
        {
            redwire3.transform.localPosition = new Vector3(-3.635f, -2.4254f, 4.835f);
            cross4.SetActive(true);
            _FourthLevelText.text = "Retry";
            FourthLevelButton.SetActive(true);
            _text.text = "Please try again";
            option3.SetActive(false);
            option2.SetActive(false);
            option1.SetActive(false);
            _redWireCol.enabled = false;
        }
    }

    public void secondButton()
    {
        if (_Option2.text == "Pin14")
        {
            redwire3.transform.localPosition = new Vector3(-3.99f, -2.4254f, 4.835f);
            greentick4.SetActive(true);
            FourthLevelButton.SetActive(true);
            _FourthLevelText.text = "Next";
            _text.text = "Correct! Please continue";
            option1.SetActive(false);
            option2.SetActive(false);
            option3.SetActive(false);
            _redWireCol.enabled = false;


        }
    }

    public void thirdButton()
    {
        if (_Option3.text == "Pin7")
        {
            redwire3.transform.localPosition = new Vector3(-3.638f, -2.4254f, 5.005f);
            cross4.SetActive(true);
            _FourthLevelText.text = "Retry";
            _text.text = "Please try again";
            FourthLevelButton.SetActive(true);
            option3.SetActive(false);
            option2.SetActive(false);
            option1.SetActive(false);
            _redWireCol.enabled = false;
        }
    }

    public void Next()
    {
        if (_FourthLevelText.text == "Retry")
        {
            redwire3.transform.localPosition = new Vector3(-3.8049f, -2.343f, 2.728f);
            //blackwire5.transform.localPosition = new Vector3(-9.72f, 4.684f, 5.573f);
            //resistor2.transform.localPosition = new Vector3(-9.72f, 4.684f, 6.14f);
            //Redled.transform.localPosition = new Vector3(-3.727f, -2.308f, 3.199f);
            _redWireCol.enabled = true;
            cross4.SetActive(false);
            _text.text = "Where do you want to connect it to?";
            FourthLevelButton.SetActive(false);
            option1.SetActive(true);
            option2.SetActive(true);
            option3.SetActive(true);

        }
        if (_FourthLevelText.text == "Next")
        {
            greentick4.SetActive(false);
            _text.text = "Next Component";
            FourthLevelButton.SetActive(false);
            blackwire5.SetActive(true);
            blackwire5.transform.localPosition = new Vector3(-3.8049f, -2.343f, 2.861f);
            resistor2.SetActive(false);
            Redled.SetActive(false);
            _blackWireCol.enabled = true;
        }
    }
 }
