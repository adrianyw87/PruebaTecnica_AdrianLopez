using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    private string screenToLoad;

    public string levelName_Init;
    public string levelName_LoadScreen;
    public string levelName_Menu;
    public string levelName_InGame;

    public int counter;


    private void Awake()
    {
        // Singleton pattern
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        // Don´t destroy on load
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        // Set the value for the scenes to load
        screenToLoad = levelName_LoadScreen;
        GoToLoadScreen();
        screenToLoad = levelName_Menu;
    }

    public void FixedUpdate()
    {
        counter++;
    }

    public void LoadScreen()
    {
        // Manage scenes
        if (screenToLoad == levelName_LoadScreen)
        {
            GoToLoadScreen();
        }
        if (screenToLoad == levelName_Menu)
        {
            GotoMenu();
        }
    }

    public void GoToLoadScreen()
    {
        SceneManager.LoadScene(levelName_LoadScreen);
    }


    public void GotoInit()
    {
        SceneManager.LoadScene(levelName_Init);
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene(levelName_Menu);
    }

    public void GotoInGame()
    {
        SceneManager.LoadScene(levelName_InGame);
    }
}
