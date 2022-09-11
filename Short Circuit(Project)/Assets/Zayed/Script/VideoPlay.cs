using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VideoPlay : MonoBehaviour
{
    public GameObject Vid1;
    public GameObject StartVid1;
    public GameObject StopVid1;
    public GameObject Vid2;
    public GameObject StartVid2;
    public GameObject StopVid2;

    public GameObject Next;
    public GameObject Back;

    public GameObject Text;
    public TMP_Text TextLED;
    public TMP_Text TextResistor;
    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(true);
        Vid1.SetActive(false);
        StopVid1.SetActive(false);
        StartVid1.SetActive(true);
        Vid2.SetActive(false);
        StopVid2.SetActive(false);
        StartVid2.SetActive(false);
        TextLED.text = " ";
        TextResistor.text = " ";
        Next.SetActive(true);
        Back.SetActive(false);
    }
    public void StartVid1Now()
    {
        Vid1.SetActive(true);
        StopVid1.SetActive(true);
        StartVid1.SetActive(false);
        Vid2.SetActive(false);
        StopVid2.SetActive(false);
        StartVid2.SetActive(false);
        Text.SetActive(false);
        TextLED.text = "LED";
        TextResistor.text = " ";
    }
    public void StopVid1Now()
    {
        Vid1.SetActive(false);
        StopVid1.SetActive(false);
        StartVid1.SetActive(true);
        Vid2.SetActive(false);
        StopVid2.SetActive(false);
        StartVid2.SetActive(false);
        Text.SetActive(false);
        TextLED.text = "LED";
        TextResistor.text = " ";
    }
    public void StartVid2Now()
    {
        Vid1.SetActive(false);
        StopVid1.SetActive(false);
        StartVid1.SetActive(false);
        Vid2.SetActive(true);
        StopVid2.SetActive(true);
        StartVid2.SetActive(false);
        Text.SetActive(false);
        TextLED.text = " ";
        TextResistor.text = "Resistor";
    }
    public void StopVid2Now()
    {
        Vid1.SetActive(false);
        StopVid1.SetActive(false);
        StartVid1.SetActive(false);
        Vid2.SetActive(false);
        StopVid2.SetActive(false);
        StartVid2.SetActive(true);
        Text.SetActive(false);
        TextLED.text = " ";
        TextResistor.text = "Resistor";
    }
    public void NextButton()
    {
        Vid1.SetActive(false);
        StopVid1.SetActive(false);
        StartVid1.SetActive(false);
        Vid2.SetActive(false);
        StopVid2.SetActive(false);
        StartVid2.SetActive(true);
        Back.SetActive(true);
        Next.SetActive(false);
        Text.SetActive(false);
        TextLED.text = " ";
        TextResistor.text = "Resistor";
    }
    public void BackButton()
    {
        Vid1.SetActive(false);
        StopVid1.SetActive(false);
        StartVid1.SetActive(true);
        Vid2.SetActive(false);
        StopVid2.SetActive(false);
        StartVid2.SetActive(false);
        Back.SetActive(false);
        Next.SetActive(true);
        Text.SetActive(false);
        TextLED.text = "LED";
        TextResistor.text = " ";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
