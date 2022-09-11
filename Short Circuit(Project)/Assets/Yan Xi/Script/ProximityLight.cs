using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityLight : MonoBehaviour
{
    public GameObject txtToDisplay;

    private bool PlayerInZone;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}