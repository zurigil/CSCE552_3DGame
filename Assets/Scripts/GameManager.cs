using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    string currScene;
    public string mainMenuScene = "MainMenu";
    public string gameOverScene = "GameOver";
    public string winScene = "Win";
    public string howToScene = "HowToScene";
    public string[] gameScenes;
    int currGameScene = -1;
    bool pause = false;
    public GameObject pauseMenu;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        currScene = SceneManager.GetActiveScene().name;
        currGameScene = Array.IndexOf(gameScenes, currScene);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause") && currGameScene >= 0)
        {
            Pause();
        }
    }
    void Pause()
    {
        pauseMenu.SetActive(!pause);
        if (!pause)
        {
            Time.timeScale = 0;
            //Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //camera = gameObject.Find("Main Camera");
            //camera.enabled = false;
        }
        pause = !pause;
    }
    void NextScene()
    {
        if (currGameScene == -1)
            return;
        currGameScene++;
        if (currGameScene >= gameScenes.Length)
        {
            GotoWin();
            return;
        }
        SceneManager.LoadScene(gameScenes[currGameScene]);
    }
    void GotoMainMenu()
    {
        currScene = mainMenuScene;
        SceneManager.LoadScene(mainMenuScene);
        Cursor.visible = true;
    }
    void GotoHowTo()
    {
        currScene = howToScene;
        SceneManager.LoadScene(howToScene);
    }
    void StartGame()
    {
        if (gameScenes == null)
            return;
        currGameScene = 1;
        currScene = gameScenes[1];
        SceneManager.LoadScene(currScene);
    }
    void GotoGameOver()
    {
        currScene = gameOverScene;
        SceneManager.LoadScene(gameOverScene);
    }
    void GotoWin()
    {
        currScene = winScene;
        SceneManager.LoadScene(winScene);
    }
    void Quit()
    {
        Application.Quit(0);
    }
}

