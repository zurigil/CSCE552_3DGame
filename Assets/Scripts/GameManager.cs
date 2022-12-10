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
    public string aboutScene = "AboutScene";
    public string[] gameScenes;
    int currGameScene = -1;
    bool pause = false;
    public GameObject pauseMenu;
    GameObject camera;
    public GameObject player;
    public static bool LoadGame;
    public GameObject carrot;
    public GameObject carrot1;
    public GameObject carrot2;
    public GameObject carrot3;
    public GameObject carrot4;
    public GameObject carrot5;
    public GameObject carrot6;
    public GameObject carrot7;
    public GameObject carrot8;
    
    // Start is called before the first frame update
    void Start()
    {
        currScene = SceneManager.GetActiveScene().name;
        currGameScene = Array.IndexOf(gameScenes, currScene);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        player = GameObject.FindGameObjectWithTag("Player");
        carrot = GameObject.FindGameObjectWithTag("Carrot");
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
            SavePosition();
            Cursor.visible = true;
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.None;
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
    void GotoAbout()
    {
        currScene = aboutScene;
        SceneManager.LoadScene(aboutScene);
    }
    void StartNewGame()
    {
        if (gameScenes == null)
            return;
        LoadGame = false;
        currGameScene = 0;
        currScene = gameScenes[0];
        SceneManager.LoadScene(currScene);
    }
    void LoadPrevGame()
    {
        if (gameScenes == null)
            return;
        LoadGame = true;
        currGameScene = 0;
        currScene = gameScenes[0];
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
        SavePosition();
        Application.Quit(0);
    }

   
    public void SavePosition()
    {
        float xPos = player.transform.position.x;
        float zPos = player.transform.position.z;

        float Carrot = carrot.transform.position.y;
        float Carrot1 = carrot1.transform.position.y;
        float Carrot2 = carrot2.transform.position.y;
        float Carrot3 = carrot3.transform.position.y;
        float Carrot4 = carrot4.transform.position.y;
        float Carrot5 = carrot5.transform.position.y;
        float Carrot6 = carrot6.transform.position.y;
        float Carrot7 = carrot7.transform.position.y;
        float Carrot8 = carrot8.transform.position.y;

        PlayerPrefs.SetFloat("X", xPos);
        PlayerPrefs.SetFloat("Z", zPos);

        PlayerPrefs.SetFloat("Carrot", Carrot);
        PlayerPrefs.SetFloat("Carrot1", Carrot1);
        PlayerPrefs.SetFloat("Carrot2", Carrot2);
        PlayerPrefs.SetFloat("Carrot3", Carrot3);
        PlayerPrefs.SetFloat("Carrot4", Carrot4);
        PlayerPrefs.SetFloat("Carrot5", Carrot5);
        PlayerPrefs.SetFloat("Carrot6", Carrot6);
        PlayerPrefs.SetFloat("Carrot7", Carrot7);
        PlayerPrefs.SetFloat("Carrot8", Carrot8);


        PlayerPrefs.Save();


    }

    /* Things to save
     * carrot count
     * game status
     * carrot position
     * 
     */
}


