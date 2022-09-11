using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff : MonoBehaviour
{

    //public GameObject txtToDisplay;             //display the UI text

    private bool PlayerInZone;                  //check if the player is in trigger

    public GameObject lightorobj1;
    public GameObject lightorobj2;
    public GameObject lightorobj3;
    public GameObject lightorobj4;

    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        //txtToDisplay.SetActive(false);
    }

    //private void Update()
    //{
    //if (PlayerInZone && Input.GetKeyDown(KeyCode.F))           //if in zone and press F key
    // {
    //lightorobj1.SetActive(!lightorobj1.activeSelf);
    //lightorobj2.SetActive(!lightorobj2.activeSelf);
    // lightorobj3.SetActive(!lightorobj3.activeSelf);
    // lightorobj4.SetActive(!lightorobj4.activeSelf);

    // gameObject.GetComponent<AudioSource>().Play();
    //gameObject.GetComponent<Animator>().Play("switch");
    //}
    //}
    public void LightOn()
    {
        lightorobj1.SetActive(!lightorobj1.activeSelf);
        lightorobj2.SetActive(!lightorobj2.activeSelf);
        lightorobj3.SetActive(!lightorobj3.activeSelf);
        lightorobj4.SetActive(!lightorobj4.activeSelf);

        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<Animator>().Play("switch");
    }
}