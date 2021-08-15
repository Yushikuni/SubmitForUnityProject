using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UI_InputWindow : MonoBehaviour
{
    public InputField input;
    public Button button;

    private string helpInput;
    void Start()
    {
        input = null;
        input = gameObject.GetComponent<InputField>();
        //var se = new InputField.SubmitEvent();
        /*se.AddListener(SubmitName);
        input.onEndEdit = se;*/
        Debug.Log("-_-");

        Debug.Log("Co je v inputu? " + input);

        helpInput = "" + input;


        button.onClick.AddListener(delegate { TaskWithParameters("nic"); });

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works

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
}
