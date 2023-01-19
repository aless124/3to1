using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Passcode2 : MonoBehaviour
{

    public string password = "742";
    private string userInput = "";
    public TextMeshPro UiText;
    public GameObject Door;
    public bool Choose = false;

    private void Start()
    {
        userInput = "";
        
    }
    public void ButtonClicked(string number)
    {
        userInput += number;
        UiText.text = userInput;
        if (userInput.Length>=3)
        {
            if (userInput==password)
            {
                UiText.text = "Successful password";
                Door.transform.position = new Vector3(-0.289999992f, 3, 7.61999989f);
                Choose = true;
            }
            else
            {
                UiText.text = "wrong password";
                userInput = "";
            }
        }
    }
}
