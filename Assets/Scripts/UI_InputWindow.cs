using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UI_InputWindow : MonoBehaviour
{
    protected UI_InputWindow ui;
    public InputField input;
    public Button button;

    private string helpInput;

    void Start()
    {
        input = gameObject.GetComponent<InputField>();


        Debug.Log("-_-");

        Debug.Log("Co je v inputu? " + input);

        //helpInput = "TEST123";//"" + input;

        //ReadStringInput(helpInput);

        //button.onClick.AddListener(delegate { TaskWithParameters(helpInput); });

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
    }
}
