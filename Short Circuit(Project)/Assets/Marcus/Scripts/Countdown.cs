using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    //float currentTime = 0f;
    public float startingTime = 10f;
    
    public Text _timer;
    public Text _test;


    public BoxCollider _bottleCol;
    public BoxCollider _solderCol;

    public GameObject redTick;
    public GameObject CdButton;


    //public GameObject bsButton;
    //public GameObject Timer;
    // Start is called before the first frame update 

    // Update is called once per frame
    public void byebyeButton()
    {
        CdButton.SetActive(false);
    }
    void Update()
    {
        startingTime -= Time.deltaTime;
        _timer.text = startingTime.ToString("0");
        if (startingTime <= 0)
        {
            startingTime = 0;
            _test.text = "You ran out of time!";
            _bottleCol.enabled = false;
            _solderCol.enabled = false;
            redTick.SetActive(true);

        }
    }

}
