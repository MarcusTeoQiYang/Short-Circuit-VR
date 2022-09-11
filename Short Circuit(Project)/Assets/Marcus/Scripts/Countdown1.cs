using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown1 : MonoBehaviour
{
    //float currentTime = 0f;
    public float startingTime = 10f;

    public Text _timer;
    public Text _test;

    public GameObject _solder;
    public GameObject _ic;
    public GameObject _greenLED;
    public GameObject _redLED;
    public GameObject _yellowLED;

    public BoxCollider _solderCol;
    public BoxCollider _icCol;
    public BoxCollider _greenLEDCol;
    public BoxCollider _redLEDCol;
    public BoxCollider _yellowLEDCol;

    public GameObject redCross;
    public GameObject CdButton;

    ScoreManager sm;
    public GameObject obj;
    bool CrossStatus = false;
    //public GameObject bsButton;
    //public GameObject Timer;
    // Start is called before the first frame update 

    // Update is called once per frame
    public void byebyeButton()
    {
        CdButton.SetActive(false);

    }
    void Start()
    {
        sm = obj.GetComponent<ScoreManager>();
    }
    void Update()
    {
        startingTime -= Time.deltaTime;
        _timer.text = startingTime.ToString("0");
        if (startingTime <= 0)
        {
            startingTime = 0;
            _test.text = "You ran out of time!";

            _solderCol.enabled = false;
            _solder.GetComponent<AI>().enabled = false;
            _solder.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;

            _icCol.enabled = false;
            _ic.GetComponent<AI>().enabled = false;
            _ic.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;

            _greenLEDCol.enabled = false;
            _greenLED.GetComponent<AI>().enabled = false;
            _greenLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;

            _yellowLEDCol.enabled = false;
            _yellowLED.GetComponent<AI>().enabled = false;
            _yellowLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;

            _redLEDCol.enabled = false;
            _redLED.GetComponent<AI>().enabled = false;
            _redLED.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;

            CrossStatus = true;
            redCross.SetActive(true);

            //if (CrossStatus = true)
            //{
            //sm.AddedPoint(0);
            //}
        }

    }

}
