using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;

    public Text safetyStatus;
    public Text patchStatus;

    String completeStatus = "Completed";
    String incompleteStatus = "Incomplete";

    bool pointStatus = false;

    private int score = 0;
    private int highscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Total points!: " + score.ToString() +"/5";
        highscoreText.text = "HIGHSCORE!: " + highscore.ToString();

        safetyStatus.text = "Lab rules: " + incompleteStatus;
        patchStatus.text = "Patch circuit: " + incompleteStatus;

        if (!pointStatus)
        {
            AddPoints.AddingPoints += AddedPoint;
        }
        pointStatus = true;
        Debug.Log("Current point is " + score);
    }

    public void AddedPoint(int pointAmt)//input parameter from the event 
    {
        score = score + pointAmt;
        scoreText.text = "Total points!: " + score.ToString() + "/5";
        Debug.Log("Points is " + score);
        if (score == 5)
        {
            safetyStatus.text = "Lab rules: " + completeStatus;
        }
    }
    public void SolderBottlePoint(int pointAmt)//input parameter from the event 
    {
        score = score + pointAmt;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
