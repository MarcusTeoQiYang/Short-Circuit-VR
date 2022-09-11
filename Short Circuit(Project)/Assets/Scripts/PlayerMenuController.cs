using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuContainer;
    private GameObject _menuInstance;
    private GvrControllerInputDevice controller;
    void Start()
    {
        _menuInstance = null;
        controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
    }

    // Update is called once per frame
    void Update()

    {
        if (controller.GetButtonUp(GvrControllerButton.App))
        {
            if (_menuInstance)
            {
                DestroyMenu();
            }
            else CreateMenu();
        }
    }

    private void CreateMenu()
    {
        _menuInstance = Instantiate(MenuContainer, Camera.main.transform.position + Camera.main.transform.forward * 3f,
            Camera.main.transform.rotation);
        
    }

    private void DestroyMenu()
    {
        Destroy(_menuInstance);
        _menuInstance = null;
    }

}
