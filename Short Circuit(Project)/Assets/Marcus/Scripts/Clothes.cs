using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clothes : MonoBehaviour
{
    public GameObject tick;
    public GameObject cross;
    public GameObject covered;
    public GameObject uncovered;
    public GameObject resetButton;
    public GameObject TextObj;
    Text _text;
    public BoxCollider correctCol;
    public BoxCollider wrongCol;
    void Start()
    {
        tick = GameObject.Find("GreenTick");
        cross = GameObject.Find("RedX1");
        tick.SetActive(false);
        cross.SetActive(false);
        resetButton.SetActive(false);
        _text = TextObj.GetComponent<Text>();

    }

    // Update is called once per frame
    public void Correct()
    {
        Destroy(uncovered);
        tick.SetActive(true);
        _text.text = "Deleted the right attire!";
        wrongCol.enabled = false;

    }

    public void Incorrect()
    {
        tick.SetActive(false);
        cross.SetActive(true);
        _text.text = "Thats not the wrong lab attire!";
        //resetButton.SetActive(true);
        correctCol.enabled = false;
    }

    public void resetNow()
    {
        cross.SetActive(false);
        tick.SetActive(false);
        resetButton.SetActive(false);
        wrongCol.enabled = true;
        correctCol.enabled = true;
        Debug.Log("Reset Hit");
       _text.text = "Delete the wrong lab attire!";

    }
}
