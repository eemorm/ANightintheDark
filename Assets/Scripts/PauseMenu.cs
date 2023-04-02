using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    public GameObject crosshair;
    public GameObject count;
    public GameObject ambience;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Play();
            }
            else 
            {
                Stop();
            }
        }
    }

    void Stop()
    { 
        PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        Paused = true;
        crosshair.SetActive(false);
        count.SetActive(false);
        ambience.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        crosshair.SetActive(true);
        count.SetActive(true);
        ambience.SetActive(true);
        Cursor.visible = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
