using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDoc : MonoBehaviour
{
    public GameObject StartGUI;
    public GameObject ResistorGUI;
    public GameObject LEDGUI;
    public GameObject RegisterGUI;


    // Start is called before the first frame update
    void Start()
    {
        StartGUI.SetActive(true);
        ResistorGUI.SetActive(false);
        LEDGUI.SetActive(false);
        RegisterGUI.SetActive(false);
    }
    public void ComponentSelect(GameObject obj)
    {
        if (obj.tag == "Resistor")
        {
            StartGUI.SetActive(false);
            ResistorGUI.SetActive(true);
            LEDGUI.SetActive(false);
            RegisterGUI.SetActive(false);
        }
        if (obj.tag == "Register")
        {
            StartGUI.SetActive(false);
            ResistorGUI.SetActive(false);
            LEDGUI.SetActive(false);
            RegisterGUI.SetActive(true);
        }
        if (obj.tag == "LED")
        {
            StartGUI.SetActive(false);
            ResistorGUI.SetActive(false);
            LEDGUI.SetActive(true);
            RegisterGUI.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
