using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectComponent : MonoBehaviour
{
    public GameObject _redLED;
    public GameObject _greenLED;
    public GameObject _yellowLED;
    public GameObject _IcChip;
    public GameObject _Resistor;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void RedLedButton()
    {
        _redLED.transform.localPosition = new Vector3(-4.565999f, -2.477186f, 5.45258f);
    }
    public void GreenLedButton()
    {
        _greenLED.transform.localPosition = new Vector3(-4.565999f, -2.477186f, 5.565587f);
    }
    public void YellowLedButton()
    {
        _yellowLED.transform.localPosition = new Vector3(-4.566f, -2.495f, 5.686f);
    }
    public void IcChipButton()
    {
        _IcChip.transform.localPosition = new Vector3(-4.563f, -2.5778f, 5.2f);
    }
    public void ResistorButton()
    {
        _Resistor.transform.localPosition = new Vector3(-4.337641f, -2.525274f, 5.509114f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
