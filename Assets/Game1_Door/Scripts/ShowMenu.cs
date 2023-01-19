using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ShowMenu : MonoBehaviour
{
    private bool Menu = true;
    public CanvasGroup CanvasGroup;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("h") && CanvasGroup.alpha ==1 && Menu == false)
        {

            CanvasGroup.alpha = 0;
            StartCoroutine(WaitForSeconds());
        }
        if (Input.GetKeyUp("h") && CanvasGroup.alpha == 0 && Menu == true) 

        {

            StartCoroutine(WaitForSeconds());
            CanvasGroup.alpha = 1;
        }  
    }

    IEnumerator WaitForSeconds()
    {

        yield return new WaitForSeconds(1);
        if (Menu)
        {
            Menu = false;
        }

        else if(Menu==false)
        {
            Menu = true;
        }
    }
}
