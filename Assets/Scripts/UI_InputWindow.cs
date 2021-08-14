using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_InputWindow : MonoBehaviour
{

    public string namePlayer;
    public string saveName;

    public Text playerName;
    public Text loadedName;

    void Update()
    {
        namePlayer = PlayerPrefs.GetString("name", "none");
        playerName.text = namePlayer;

        Debug.Log("Jmeno hrace: " + playerName);
    }

    public void SetName()
    {
        //saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }

    private void Awake()
    {
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
