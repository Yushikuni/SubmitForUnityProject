using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(InputField))]
public class UI_InputWindow : MonoBehaviour
{
    public GameObject inputFieldObj; //Add this
    const string playerNamePrefKey = "PlayerName";

    string playerName = null;


    void Start()
    {
        Debug.Log("-_-");
        gameObject.GetComponent<InputField>().onEndEdit.AddListener(displayText);

        string defaultName = string.Empty;
        InputField _inputField = this.GetComponent<InputField>();
        if (_inputField != null)
        {
            if (PlayerPrefs.HasKey(playerNamePrefKey))
            {
                defaultName = PlayerPrefs.GetString(playerNamePrefKey);
                _inputField.text = defaultName;
            }
        }
        playerName = defaultName;
        //input = gameObject.GetComponent<InputField>();        

        Debug.Log("Co je v playerName?? " + playerName);

        //helpInput = "TEST123";//"" + input;

        //ReadStringInput(helpInput);
        //InputChanged(input);

        //button.onClick.AddListener(delegate { TaskWithParameters(input.text); });
        //ReadStringInput(input.text);

    }
    private void displayText(string textInField)
    {
        print(textInField);
    }
    public void submitName()
    {
        string name = GameObject.Find("InputField").GetComponent<InputField>().text;
        print("Saving " + name);

    }
    /*
    public void SetPlayerNickName()//Leave that empty)
    {

        InputField inputField = inputFieldObj.GetComponent<InputField>();
        string value = inputField.text;
        if (string.IsNullOrEmpty(value))
        {
            Debug.LogError("Player Name is empty");
            return;
        }
        Debug.Log(PlayerPrefs.GetString(playerNamePrefKey));
        PhotonNetwork.NickName = value;
        PlayerPrefs.SetString(playerNamePrefKey, value);
    }*/
    /*
    public void InputChanged(InputField _input)
    {
        string value = _input.text;
        //Do code with 'value' here.
        Debug.Log(value);
    }


    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    public string SubmitName(string arg0)
    {
        Debug.Log(arg0);

        return arg0;
    }

    public void Show()
    {
        ui.Show();
    }

    public void ReadStringInput(string s)
    {
        helpInput = s;
        Debug.Log(helpInput);
    }*/
}
