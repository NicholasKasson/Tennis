using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string singleplayer;
    public string multiplayer;
    // Start is called before the first frame update
    public void LoadSingle()
    {
        SceneManager.LoadScene(singleplayer);
    }
    public void LoadMultiplayer()
    {
        SceneManager.LoadScene(multiplayer);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
