using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Passcode : MonoBehaviour
{
    public int number = 1;
    public UnityEvent KeypadClicked;


    private void OnMouseDown()
    {
        KeypadClicked.Invoke();
    }
    /*
    private void OnMouseDown()
    {
        CodeFunction(number);
    }
    public void CodeFunction(string Nr)
    {
        if (index>=4)
        {
            UiText.text = "Wrong Password";
        }

        index++;
        Debug.Log(index);
        number = number + Nr;
        UiText.text = number;
        Enter();
    }
    public void Enter()
    {
        if (number==code)
        {
            UiText.text = "Success";
        }
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(2);
        UiText.text = "";
    }
    */
}
