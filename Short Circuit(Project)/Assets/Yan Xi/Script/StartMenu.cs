using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public string VRMainScene;
    public GameObject OptionScreen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene(VRMainScene);
        
    }
    public void OpenOptions()
    {
        OptionScreen.SetActive(true);

    }
    public void CloseOptions()
    {
        OptionScreen.SetActive(false);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
        //Debug.Log("Game is quitting");

    }
}
