using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string StartMenu;

    public BoxCollider rulesCol;
    public BoxCollider patchCol;
    public BoxCollider boardCol;
    public BoxCollider rulesTableCol;
    public BoxCollider patchTableCol;

    public GameObject AboutUs;
    public GameObject UIBoard;

    private GvrControllerInputDevice controller;

    Text _text;

    public GameObject _shirtText;
    public GameObject _FootText;
    public GameObject _BottleText;
    public GameObject _NeatText;

    public GameObject _player;

    public GameObject timer1;
    public GameObject Timer1Button;
    public GameObject timer2;
    public GameObject Timer2Button;

    public GameObject _StartButton;
    public GameObject _PatchText;
    void Start()
    {
        //Transform selfTransform = GetComponent<Transform>();
        patchCol.enabled = false;
        rulesCol.enabled = false;
        boardCol.enabled = false;
        rulesTableCol.enabled = true;
        patchTableCol.enabled = true;


        _StartButton.SetActive(false);
        _PatchText.SetActive(false);

        _shirtText.SetActive(false);
        _FootText.SetActive(false);
        //_BottleText.SetActive(false);
        _NeatText.SetActive(false);
        timer1.SetActive(false);
        timer2.SetActive(false);
        Timer1Button.SetActive(false);
        Timer2Button.SetActive(false);
        controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);

        AboutUs.SetActive(false);
    }
    public void MenuButtonClick(int index)
    {
        //_text.text = "Clicked Button" + index.ToString();
        switch (index)
        {

            case 0:
                print("Click Button" + index);
                break;
            case 1:
                //_player.transform.position = new Vector3(-2.65f, 3, 4.68f);
                print("Click Button" + index);
                break;
            case 2:
                print("Click Button" + index);
                break;
            default:
                break;
        }
    }
    public void SafetyButton()
    {
        _player.transform.localPosition = new Vector3(4.59f, 6.18f, 5.101f);
        _player.transform.rotation = Quaternion.Euler(0, 90, 0);
        patchCol.enabled = true;
        boardCol.enabled = true;
        rulesCol.enabled = false;
        rulesTableCol.enabled = false;
        ActivateRules();
    }
    public void PatchButton()
    {
        _player.transform.position = new Vector3(-6.5f, 6.18f, 8.49f);
        _player.transform.rotation = Quaternion.Euler(0, 270, 0);
        rulesCol.enabled = true;
        boardCol.enabled = true;
        patchCol.enabled = false;
        patchTableCol.enabled = false;
        ActivatePatch();
    }
    public void BackButton()
    {
        _player.transform.position = new Vector3(-0.21f, 3, 0);
        _player.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    public void ActivateRules()
    {

        _shirtText.SetActive(true);
        _FootText.SetActive(true);
        timer1.SetActive(true);
        timer2.SetActive(true);
        Timer1Button.SetActive(true);
        Timer2Button.SetActive(true);
        //_BottleText.SetActive(true);
        //_NeatText.SetActive(true);
    }
    public void ActivatePatch()
    {
        _StartButton.SetActive(true);
        _PatchText.SetActive(true);
    }
    public void DeactivateRules()
    {
        _shirtText.SetActive(false);
        _FootText.SetActive(false);
        _BottleText.SetActive(false);
        _NeatText.SetActive(false);
        timer1.SetActive(false);
        timer2.SetActive(false);
        Timer1Button.SetActive(false);
        Timer2Button.SetActive(false);
    }
    public void DeactivatePatch()
    {
        _StartButton.SetActive(false);
        _PatchText.SetActive(false);
    }
    public void AboutUsPage()
    {
        AboutUs.SetActive(true);
        UIBoard.SetActive(false);
    }
    public void BackToUIBoard()
    {
        AboutUs.SetActive(false);
        UIBoard.SetActive(true);
    }
    public void Quit()
    {
        SceneManager.LoadScene(StartMenu);
    }


    void Update()
    {
        if (controller.GetButtonUp(GvrControllerButton.App))
        {
            _player.gameObject.transform.position = new Vector3(0.88f, 6.18f, -4.6286f);
            _player.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            patchCol.enabled = false;
            rulesCol.enabled = false;
            boardCol.enabled = false;
            patchTableCol.enabled = true;
            rulesTableCol.enabled = true;
            DeactivateRules();
            DeactivatePatch();
        }
    }
}
