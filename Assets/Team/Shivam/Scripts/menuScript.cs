using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public GameObject LogoImage;
    public GameObject Meteor;
    public GameObject startButton;
    public GameObject exitButton;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        LogoImage.SetActive(false);
        Meteor.SetActive(false);
        startButton.SetActive(false);
        exitButton.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
