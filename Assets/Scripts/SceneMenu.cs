using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;
    bool canvasIsOpen = false;
    
    public void OpenCanvas()
    {
        if (!canvasIsOpen)
        {
            menuCanvas.SetActive(true);
            canvasIsOpen = true;
        }
        else
        {
            menuCanvas.SetActive(false);
            canvasIsOpen = false;
        }
    }
    
    public void MainManu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
