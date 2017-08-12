using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour {
    public KeyCode Escape;
    GameObject PauseMenu;
    bool paused;

	// Use this for initialization
	void Start () {

        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");

	}
	
	// Update is called once per frame
	void Update () {

      if (Input.GetKeyDown(KeyCode.Escape))

        {
            paused = !paused;
        }

      if (paused)

        {
            PauseMenu.SetActive(true);
            Time.timeScale = 1;
        }

      else if (!paused)

        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
	}

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void Save()
    {
        PlayerPrefs.SetInt("currentscenesave", SceneManager.GetActiveScene().buildIndex);
    }

    public void Load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Help()
    {
        SceneManager.LoadScene(11);
    }
}

