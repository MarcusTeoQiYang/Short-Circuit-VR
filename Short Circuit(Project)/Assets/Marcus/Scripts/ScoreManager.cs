using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public GameObject _player;


    public Text scoreText;
    public Text highscoreText;

    public Text safetyStatus;
    public Text patchStatus;

    public Text instructionStatus;

    String completeStatus = "Completed";
    String incompleteStatus = "Incomplete";

    public GameObject LabSafetyButton;
    public GameObject PatchCircuitButton;

    bool pointStatus = false;

    bool LabSafety = false;
    bool PatchCircuit = false;

    private int score = 0;
    private int highscore = 0;

    bool ShirtStatus = false;
    bool ShoeStatus = false;
    bool BottleStatus = false;
    bool NeatStatus = false;

    bool PickIC = false;
    bool PickRes = false;
    bool PickRed = false;
    bool PickYellow = false;
    bool PickGreen = false;

    public GameObject ICButton;
    public GameObject ResButton;
    public GameObject RedButton;
    public GameObject YellowButton;
    public GameObject GreenButton;

    public GameObject trophy;

    public BoxCollider CabinetCol;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Total points!: " + score.ToString() + "/8";
        highscoreText.text = "HIGHSCORE!: " + PlayerPrefs.GetInt("highscore", 0).ToString();
        safetyStatus.text = "Lab rules: " + incompleteStatus;
        patchStatus.text = "Patch circuit: " + incompleteStatus;

        trophy.SetActive(false);

        CabinetCol.enabled = false;
        ICButton.SetActive(false);
        ResButton.SetActive(false);
        RedButton.SetActive(false);
        YellowButton.SetActive(false);
        GreenButton.SetActive(false);

        //PatchCircuitButton.SetActive(true);

        if (!pointStatus)
        {
            AddPoints.AddingPoints += AddedPoint;
        }
        pointStatus = true;
        Debug.Log("Current point is " + score);
        PatchCircuitButton.SetActive(false);
    }

    public void StatusTrue(GameObject obj)
    {
        if (obj.name == "Covered_Attire")
        {
            ShirtStatus = true;
        }
        if (obj.name == "Uncovered_attire")
        {
            ShirtStatus = true;
        }
        if (obj.name == "shoe")
        {
            ShoeStatus = true;
        }
        if (obj.name == "Slipper")
        {
            ShoeStatus = true;
        }
        if (obj.name == "CountdownButton")
        {
            BottleStatus = true;
        }
        if (obj.name == "StartSectionButton")
        {
            NeatStatus = true;
        }
        if (ShirtStatus && ShoeStatus && BottleStatus && NeatStatus == true)
        {
            safetyStatus.text = "Lab rules: " + completeStatus;
            instructionStatus.text = "Congratulations you have completed the 'Lab safety section' please collect your components for circuit patching in the cabinet on the left to move on!";
            CabinetCol.enabled = true;
            ICButton.SetActive(true);
            ResButton.SetActive(true);
            RedButton.SetActive(true);
            YellowButton.SetActive(true);
            GreenButton.SetActive(true);
            //PatchCircuitButton.SetActive(true);
            LabSafety = true;
        }
    }
    public void CollectStatus(GameObject obj1)
    {
        if (obj1.name == "PickIcChip")
        {
            PickIC = true;
        }
        if (obj1.name == "PickResistor")
        {
            PickRes = true;
        }
        if (obj1.name == "PickRedLED")
        {
            PickRed = true;
        }
        if (obj1.name == "PickYellowLED")
        {
            PickYellow = true;
        }
        if (obj1.name == "PickGreenLED")
        {
            PickGreen = true;
        }
        if (PickIC && PickGreen && PickRes && PickRed && PickYellow == true)
        {
            PatchCircuitButton.SetActive(true);
            instructionStatus.text = "Components collected. Please move on to circuit patching!";
        }
    }
    public void ByeIC()
    {
        ICButton.SetActive(false);
    }
    public void ByeRes()
    {
        ResButton.SetActive(false);
    }
    public void ByeRed()
    {
        RedButton.SetActive(false);
    }
    public void ByeYellow()
    {
        YellowButton.SetActive(false);
    }
    public void ByeGreen()
    {
        GreenButton.SetActive(false);
    }
    public void PatchDone()
    {
        PatchCircuit = true;
        if (PatchCircuit == true)
        {
            patchStatus.text = "Patch circuit: " + completeStatus;
            instructionStatus.text = "Congratulations you have completed the 'Patch circuit section' thank you for completing this VR experience, we hope that you enjoyed it!";
            trophy.SetActive(true);
        }
    }

    public void AddedPoint(int pointAmt)//input parameter from the event 
    {
        score = score + pointAmt;
        scoreText.text = "Total points!: " + score.ToString() + "/8";
        Debug.Log("Points is " + score);
        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
            highscoreText.text = "HIGHSCORE!: " + score.ToString();
        }


    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteAll();
        highscoreText.text = "HIGHSCORE!: " + "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
