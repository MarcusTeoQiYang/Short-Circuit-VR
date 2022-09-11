using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameObject TextObj;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = TextObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
