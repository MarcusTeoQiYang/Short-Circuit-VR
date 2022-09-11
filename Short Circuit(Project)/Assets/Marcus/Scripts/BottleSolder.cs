using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleSolder : MonoBehaviour
{
    Animator anim;

    ScoreManager sm;
    //public GameObject _bottle;
    //public GameObject _solder;

    public GameObject obj;

    public GameObject _greenTick;
    public GameObject _redTick;

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public GameObject TextObj;
    Text _text;

    public GameObject _socket;

    bool solderlocate = false;
    bool bottlelocate = false;

    bool TickStatus = false;

    public BoxCollider _bottleCol;
    public BoxCollider _solderCol;

    public GameObject Countdown;
    public GameObject _BottleSolderText;

    void Start()
    {
        sm = obj.GetComponent<ScoreManager>();
        _text = TextObj.GetComponent<Text>();
        _greenTick.SetActive(false);
        _redTick.SetActive(false);
        _socket.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
        _BottleSolderText.SetActive(false);
        _bottleCol.enabled = false;
        _solderCol.enabled = false;
    }


    bool DoubleClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            return true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        return false;
    }
    public void SolderBottleClick(GameObject obj)
    {
        if (DoubleClick())
        {
            if (obj.name == "Bottle")
            {
                //_bottle.transform.localPosition = new Vector3(-6.194712f, 3.416382f, 1.579f);
                _bottleCol.enabled = false;
                //return;
                bottlelocate = true;
                anim = obj.GetComponent<Animator>();
                anim.SetBool("BottleActive", true);
            }
            if (obj.name == "Soldering_gun (1)")
            {
                //_solder.transform.localPosition = new Vector3(-6.95f, 2.832467f, 1.75f);
                _solderCol.enabled = false;
                //return;
                solderlocate = true;
                anim = obj.GetComponent<Animator>();
                anim.SetBool("SolderActive", true);
            }
            if (solderlocate == true || bottlelocate == true)
            {
                _text.text = "First item shifted!";
            }
            if (solderlocate && bottlelocate == true)
            {
                TickStatus = true;
                _socket.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
                _text.text = "Well done!";

            }
            if (TickStatus == true)
            {
                _greenTick.SetActive(true);
                sm.AddedPoint(1);
                Countdown.GetComponent<Countdown>().enabled = false;
            }


            }
        }
    public void bsButton()
    {
        _BottleSolderText.SetActive(true);
        _bottleCol.enabled = true;
        _solderCol.enabled = true;
    }



        // Start is called before the first frame update


        // Update is called once per frame
        void Update()
        {

        }
    }

