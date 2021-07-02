using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuPage;

    public void Pause()
    {
            Time.timeScale = 0;
            menuPage.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        menuPage.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
