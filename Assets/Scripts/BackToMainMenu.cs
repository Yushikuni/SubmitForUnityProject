using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    void Start()
    {

    }
    public void BackToMain_Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void Back()
    {
        print("Going back");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
