using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DeleteObj : MonoBehaviour
{
    MeshRenderer rend;
    public Transform spawnPos;
    public GameObject spawnee;
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        
    }
    public void deleteObj(bool enable)
    {
        if (enable)
        {
            obj = (GameObject)Instantiate(obj, transform.position, transform.rotation);
            Destroy(obj);
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }

    }



}
