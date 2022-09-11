using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MenuController : MonoBehaviour
{
    public BoxCollider rulesCol;
    public BoxCollider patchCol;
    public BoxCollider boardCol;
    public GameObject _player;
    void Start()
    {
        //Transform selfTransform = GetComponent<Transform>();
        patchCol.enabled = false;
        rulesCol.enabled = false;
        boardCol.enabled = false;
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
        _player.transform.localPosition = new Vector3(1.61f, 3, 2.49f);
        _player.transform.rotation = Quaternion.Euler(0, 90, 0);
        patchCol.enabled = true;
        boardCol.enabled = true;
        rulesCol.enabled = false;
    }
    public void PatchButton()
    {
        _player.transform.position = new Vector3(-2.65f, 3, 4.68f);
        _player.transform.rotation = Quaternion.Euler(0, 270, 0);
        rulesCol.enabled = true;
        boardCol.enabled = true;
        patchCol.enabled = false;
    }
    public void BackButton()
    {
        _player.transform.position = new Vector3(-0.21f, 3, 0);
        _player.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
