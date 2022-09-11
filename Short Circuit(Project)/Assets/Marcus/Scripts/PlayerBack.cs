using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBack : MonoBehaviour
{
    public BoxCollider rulesCol;
    public BoxCollider patchCol;
    public BoxCollider boardCol;
    public BoxCollider rulesTableCol;
    public BoxCollider patchTableCol;

    private GvrControllerInputDevice controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.GetButtonUp(GvrControllerButton.App))
        {
            this.gameObject.transform.position = new Vector3(0.88f, 3, -1.93f);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            patchCol.enabled = false;
            rulesCol.enabled = false;
            boardCol.enabled = false;
            patchTableCol.enabled = true;
            rulesTableCol.enabled = true;
        }
    }
}