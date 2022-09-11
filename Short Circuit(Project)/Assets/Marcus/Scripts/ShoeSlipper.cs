using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoeSlipper : MonoBehaviour
{
    Animator anim;

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
                anim = obj.GetComponent<Animator>();
                //obj.transform.localPosition = new Vector3(0.4128332f, -1.445111f, 0.46f);
                _shoeCol.enabled = false;
                anim.SetBool("SlipperActive", true);
                anim.SetBool("SlipperReset", false);
                GameObject rCross = Instantiate(_redCross, RcrossPos.position, RcrossPos.rotation);
                rCross.tag = "Cross";
                _text.text = "You selected the wrong footwear, try again!";
                //prefabList.Add(rCross);
                //resetButton.SetActive(true);
            }

            if (obj.name == "shoe")
            {
                anim = obj.GetComponent<Animator>();
                //obj.transform.localPosition = new Vector3(0.434f, -1.525147f, 0.465f);
                anim.SetBool("ShoeActive", true);
                _slipperCol.enabled = false;
                _shoeCol.enabled = false;
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

        //_shoe.transform.localPosition = new Vector3(0.434f, -1.525147f, 2.334f);
        _slipperCol.enabled = true;
        resetButton.SetActive(true);
        
        //_slipper.transform.localPosition = new Vector3(0.4128332f, -1.445111f, 1.404824f);
        _shoeCol.enabled = true;
        resetButton.SetActive(false);
        _text.text = "Select the right lab footwear!";
        anim.SetBool("SlipperActive", false);
        anim.SetBool("SlipperReset", true);


        Debug.Log("Resetted");
    }
    void Start()
    {
        _slipperCol = _slipper.GetComponent<BoxCollider>();
        _shoeCol = _shoe.GetComponent<BoxCollider>();
        _text = TextObj.GetComponent<Text>();
        resetButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
