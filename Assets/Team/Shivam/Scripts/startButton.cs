using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public GameObject LogoImage;
    public GameObject Meteor;
    public GameObject exitButton;

    void Start()
    {

    }

    public void playGame()
    {
        SceneManager.LoadScene("");
        LogoImage.SetActive(false);
        Meteor.SetActive(false);
        exitButton.SetActive(false);
    }
}
