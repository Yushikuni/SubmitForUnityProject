using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(InputField))]
public class UI_InputWindow : MonoBehaviour
{
    public GameObject inputFieldObj; //Add this
    const string playerNamePrefKey = "PlayerName";

    public string playerNameDefault = "Player name";
    public Text PlayerName;


    void Start()
    {
        Debug.Log("-_-");
        gameObject.GetComponent<InputField>().onEndEdit.AddListener(displayText);
        Debug.Log("Co je v playerName?? " + playerNameDefault);      
    }

    private void displayText(string textInField)
    {
        print(textInField);
    }

    public void SubmitName()
    {
        PlayerName.text = GameObject.Find("InputField").GetComponent<InputField>().text;
        print("Saving " + PlayerName.text);
        Hide();
    }

    public void Show()
    {
        inputFieldObj.SetActive(true);
        print("oteveno POP-UP okno!!!");
    }

    public void Hide()
    {
        inputFieldObj.SetActive(false);
    }
}
