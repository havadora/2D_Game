using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class UISys : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject MainMenu;
    public GameObject pausemenu;
    public GameObject how;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        MainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (GamePause)
            {
                Resume();
            }
            else
            {
                Pauses();
            }
        }

    }
    public void Resume()
    {

        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    void Pauses()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Play()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void How()
    {
        MainMenu.SetActive(false);
        how.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Back()
    {
        MainMenu.SetActive(true);
        how.SetActive(false);
        Time.timeScale = 0f;
    }
}
