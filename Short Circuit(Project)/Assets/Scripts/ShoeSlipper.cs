using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoeSlipper : MonoBehaviour
{
    public GameObject _slipper;
    public GameObject _shoe;

    public Transform RcrossPos;
    public GameObject _redCross;
    public Transform GcrossPos;
    public GameObject _greenCross;

    public GameObject TextObj;
    Text _text;

    BoxCollider _slipperCol;
    BoxCollider _shoeCol;
    bool submit = false;

    public GameObject resetButton;

    public void ShoeSlipperClick(GameObject obj)
    {

        if (!submit)
        {
            if (obj.name == "Slipper")
            {
                obj.transform.localPosition = new Vector3(4.2536f, -2.546186f, 0.6353161f);

                _shoeCol.enabled = false;
                GameObject rCross = Instantiate(_redCross, RcrossPos.position, RcrossPos.rotation);
                rCross.tag = "Cross";
                _text.text = "You selected the wrong footwear, try again!";
                //prefabList.Add(rCross);
                resetButton.SetActive(true);
            }

            if (obj.name == "shoe")
            {
                obj.transform.localPosition = new Vector3(4.247378f, -2.531f, 0.635f);

                _slipperCol.enabled = false;
                GameObject gTick = Instantiate(_greenCross, GcrossPos.position, GcrossPos.rotation);
                gTick.tag = "Tick";
                _text.text = "Thats right!";
                //prefabList.Add(gTick);
                resetButton.SetActive(false);
            }
            submit = true;
            

        }
      

            
    }
    public void resetNow()
    {
        submit = false;
        Destroy(GameObject.FindWithTag("Cross"));

        _shoe.transform.localPosition = new Vector3(4.301377f, -2.567186f, 1.571328f);
        _slipperCol.enabled = true;
        resetButton.SetActive(true);
        
        _slipper.transform.localPosition = new Vector3(4.247378f, -2.531f, 1.049f);
        _shoeCol.enabled = true;
        resetButton.SetActive(false);
        _text.text = "Select the right lab footwear!";

        Debug.Log("Resetted");
    }
    void Start()
    {
        _slipperCol = _slipper.GetComponent<BoxCollider>();
        _shoeCol = _slipper.GetComponent<BoxCollider>();
        _text = TextObj.GetComponent<Text>();
        resetButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
