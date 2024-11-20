using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject fadeScreenOut;
    [SerializeField] AudioSource swordSound;

    public void StartGame()
    {
        StartCoroutine(FirstFadeOut());
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainManu()
    {
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {
        SceneManager.LoadScene(9);
    }

    IEnumerator FirstFadeOut()
    {
        fadeScreenOut.SetActive(true);
        swordSound.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
