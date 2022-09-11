using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CircuitPatching : MonoBehaviour
{
    ScoreManager sm;

    public GameObject obj;
    public GameObject StartButton; //1st level canvas
    public GameObject option1; //user option
    public GameObject option2; //user option
    public GameObject option3; //user option
    public GameObject Redled;
    public GameObject Greenled;
    public GameObject Yellowled;
    public GameObject Blueled;
    public GameObject redwire;
    public GameObject redwire2;
    public GameObject redwire3;
    public GameObject blackwire;
    public GameObject blackwire2;
    public GameObject blackwire3;
    public GameObject blackwire4;
    public GameObject blackwire5;
    public GameObject Greenbulb;
    public GameObject Yellowbulb;
    public GameObject ResultText; //text from the result canvas
    public GameObject StartButtonText; //text of the start button
    public GameObject cross; // cross image for 1st circuit patch
    public GameObject cross2; // cross image for 2nd circuit patch
    public GameObject cross3; // cross image for 3nd circuit patch
    public GameObject greentick0;
    public GameObject greentick2;
    public GameObject greentick3;
    public GameObject ic;
    public GameObject ic2;
    public GameObject Option1; //text from the option 1 canvas button
    public GameObject Option2; //text from the option 2 canvas button
    public GameObject Option3; //text from the option 3 canvas button
    public GameObject partitionLVL1; //1st partition
    public GameObject partitionLVL2; //2nd partition
    public GameObject partitionLVL3; //3rd partition
    public GameObject SecondLevelButton; //button for the 2nd circuit patch
    public GameObject ThirdLevelButton; //button for the 3rd circuit patch
    public GameObject FourthLevelButton; //button for the 4th circuit patch
    public GameObject SecondLvlText; // text of the button for the 2nd circuit patch
    public GameObject ThirdLvlText; // text of the button for the 3rd circuit patch
    public GameObject resistor;
    public GameObject resistor2;
    public GameObject resistor3;
    public GameObject cross4; // cross image for 4th circuit patch
    public GameObject greentick4; // tick image for 4th circuit patch
    Text _text;
    Text _StartButtonText;
    Text _Option1;
    Text _Option2;
    Text _Option3;
    Text _secondLvlButton;
    Text _thirdLvlButton;

    public BoxCollider _redWireCol;
    public BoxCollider _blackWireCol;
    public BoxCollider _resistorCol;
    public BoxCollider _redLEDCol;

    void Start()
    {
        //StartButton.SetActive(true);
        SecondLevelButton.SetActive(false);
        ThirdLevelButton.SetActive(false);
        FourthLevelButton.SetActive(false);
        option1.SetActive(false);
        option2.SetActive(false);
        option3.SetActive(false);
        _text = ResultText.GetComponent<Text>(); //obtain text from the result canvas
        _StartButtonText = StartButtonText.GetComponent<Text>();
        _Option1 = Option1.GetComponent<Text>();
        _Option2 = Option2.GetComponent<Text>();
        _Option3 = Option3.GetComponent<Text>();
        _secondLvlButton = SecondLvlText.GetComponent<Text>();
        _thirdLvlButton = ThirdLvlText.GetComponent<Text>();
        cross.SetActive(false);
        ic.SetActive(false);

        partitionLVL1.SetActive(false);
        partitionLVL2.SetActive(false);
        partitionLVL3.SetActive(false);
        cross2.SetActive(false);
        greentick0.SetActive(false);
        greentick2.SetActive(false);
        greentick3.SetActive(false);
        cross3.SetActive(false);

        _redLEDCol.enabled = false;
        sm = obj.GetComponent<ScoreManager>();
    }

    public void startPatch()  //when user clicks the start button for 1st time
    {
        Redled.transform.localPosition = new Vector3(-3.727f, -2.252f, 2.805f);
        Greenled.transform.localPosition = new Vector3(-3.727f, -2.26f, 3.165f);
        Greenled.transform.rotation = Quaternion.Euler(-181.591f, 0.720993f, 99.37199f);
        redwire.transform.localPosition = new Vector3(-3.6439f, -2.4359f, 3.7002f);
        redwire.transform.rotation = Quaternion.Euler(90f, 0f, 90f);
        blackwire.transform.localPosition = new Vector3(-3.6691f, -2.4359f, 3.6747f);
        blackwire.transform.rotation = Quaternion.Euler(90f, 0f, 90f);
        option1.SetActive(true);
        option2.SetActive(true);
        StartButton.SetActive(false);
    }

    public void correctLED()
    {
        if (_Option2.text == "2")
        {
            Greenled.transform.localPosition = new Vector3(-3.7809f, -2.331f, 3.6849f);
            Greenled.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            option1.SetActive(false);
            option2.SetActive(false);
            _text.text = "Correct!";
            _text.fontSize = 40;
            //cross.SetActive(false);
            StartButton.SetActive(true);
            _StartButtonText.text = "Continue";
            _StartButtonText.fontSize = 43;
            Greenbulb.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            Redled.SetActive(false);
            sm.AddedPoint(1);
            //tick.SetActive(true);
            greentick0.SetActive(true);

        }

        if (_Option2.text == "-")
        {
            _text.text = "Correct!";
            SecondLevelButton.SetActive(true);
            blackwire3.transform.localPosition = new Vector3(-3.661f, -2.431f, 4.102f);
            _secondLvlButton.text = "Continue";
            greentick2.SetActive(true);
            option1.SetActive(false);
            option2.SetActive(false);
            sm.AddedPoint(1);
            StartButton.SetActive(false);
        }

        if (_Option2.text == "False")
        {
            cross3.SetActive(true);
            _text.text = "Incorrect! try again";
            option1.SetActive(false);
            option2.SetActive(false);
            ThirdLevelButton.SetActive(true);
            _thirdLvlButton.text = "Retry";
            SecondLevelButton.SetActive(false);
            StartButton.SetActive(false);
        }
    }

    public void Incorrect()
    {
        if (_Option1.text == "1")
        {
            _text.text = "Incorrect! try again";
            cross.SetActive(true);
            cross.transform.localPosition = new Vector3(-9.779f, 5.05f, 7.74f);
            StartButton.SetActive(true);
            _StartButtonText.text = "Retry";
            Redled.transform.localPosition = new Vector3(-3.7809f, -2.331f, 3.6849f);
            Redled.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            option1.SetActive(false);
            option2.SetActive(false);
        }

        if (_Option1.text == "+")
        {
            _text.text = "Incorrect! try again";
            blackwire2.transform.localPosition = new Vector3(-3.661f, -2.431f, 4.102f);
            cross2.SetActive(true);
            SecondLevelButton.SetActive(true);
            _secondLvlButton.text = "Retry";
            option1.SetActive(false);
            option2.SetActive(false);
            StartButton.SetActive(false);
        }

        if (_Option1.text == "True")
        {
            _text.text = "Correct!";
            option1.SetActive(false);
            option2.SetActive(false);
            greentick3.SetActive(true);
            ThirdLevelButton.SetActive(true);
            FourthLevelButton.SetActive(false);
            _thirdLvlButton.text = "Continue";
            SecondLevelButton.SetActive(false);
            StartButton.SetActive(false);
            Yellowbulb.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            sm.AddedPoint(1);
        }
    }

    public void Next()
    {
        if (_StartButtonText.text == "Retry")
        {
            cross.SetActive(false);
            _text.text = "Select correct component";
            Redled.transform.localPosition = new Vector3(-3.727f, -2.252f, 2.805f);
            Redled.transform.rotation = Quaternion.Euler(0f, 0f, 81.533f);
        }

        if (_StartButtonText.text == "Continue")
        {
            //Greenbulb.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            Greenled.transform.localPosition = new Vector3(-3.8783f, -2.331f, 3.6849f);
            Greenled.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            Redled.SetActive(true);
            Redled.transform.localPosition = new Vector3(-4.565999f, -2.477186f, 5.45258f);
            _text.text = "Where should the black wire be connected to?";
            ic.SetActive(true);
            _Option1.text = "+";
            _Option2.text = "-";
            blackwire3.transform.localPosition = new Vector3(-3.801f, -2.3371f, 3.25f);
            blackwire2.transform.localPosition = new Vector3(-3.798f, -2.336f, 2.796f);
            partitionLVL1.SetActive(true);
            for (int i = 1; i < 2; i++)
            {
                Vector3 position = new Vector3(-10.133f, 4.482f, 8.28f);
                Instantiate(redwire, position, redwire.transform.rotation);
            }
        }
    }

    public void secondlvl()
    {
        if (_secondLvlButton.text == "Retry")
        {
            cross2.SetActive(false);
            _text.text = "Where should the black wire be connected to?";
            blackwire2.transform.localPosition = new Vector3(-3.798f, -2.336f, 2.796f);
            SecondLevelButton.SetActive(false);
            option1.SetActive(true);
            option2.SetActive(true);
        }
        if (_secondLvlButton.text == "Continue")
        {
            partitionLVL2.SetActive(true);
            _text.text = "Is the circuit connected VCC to GND?";
            Yellowled.transform.localPosition = new Vector3(-3.932f, -2.339f, 4.455f);
            Yellowled.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            resistor.transform.position = new Vector3(-9.939f, 4.475f, 9.678f);
            resistor.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            redwire2.transform.position = new Vector3(-9.519f, 4.48f, 9.725f);
            blackwire4.transform.localPosition = new Vector3(-10.256f, 4.4778f, 9.412f);
            SecondLevelButton.SetActive(false);
            blackwire2.transform.localPosition = new Vector3(-11.53f, 4.251f, 10.289f);
            option1.SetActive(true);
            option2.SetActive(true);
            _Option1.text = "True";
            _Option2.text = "False";
            _redLEDCol.enabled = true;
        }
    }

    public void thirdLevel()
    {
        if (_thirdLvlButton.text == "Retry")
        {
            cross3.SetActive(false);
            _text.text = "Is the circuit connected to VCC to GRND?";
            ThirdLevelButton.SetActive(false);
            option1.SetActive(true);
            option2.SetActive(true);
        }

        if (_thirdLvlButton.text == "Continue")
        {
            greentick3.SetActive(true);
            partitionLVL3.SetActive(true);
            ic2.transform.localPosition = new Vector3(-3.897f, -2.484f, 4.911f);
            ic2.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            _text.text = "Patch the circuit as shown in the diagram, click the individual components below";
            _text.fontSize = 55;
            ThirdLevelButton.SetActive(false);
            _blackWireCol.enabled = false;
            _resistorCol.enabled = false;
            _redLEDCol.enabled = false;

            redwire3.transform.localPosition = new Vector3(-3.8049f, -2.343f, 2.728f);
            //blackwire5.transform.localPosition = new Vector3(-9.72f, 4.684f, 5.573f);
            //resistor2.transform.localPosition = new Vector3(-9.72f, 4.684f, 6.14f);
            //resistor3.transform.localPosition = new Vector3(-9.72f, 4.684f, 6.02f);
            //Blueled.transform.localPosition = new Vector3(-3.727f, -2.308f, 3.256f);
            //Redled.transform.localPosition = new Vector3(-3.727f, -2.308f, 3.199f);
            cross4.SetActive(false);
            greentick4.SetActive(false);
        }
    }

}
