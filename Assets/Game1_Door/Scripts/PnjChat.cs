using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class PnjChat : MonoBehaviour
{
    public Passcode2 passcode2;
    public Text text;
    public CanvasGroup CanvasGroup;
    private bool CanTalk;
    private bool AlreadyTalked;
    private bool FirstTime = true;
    // Start is called before the first frame update
    void Start()
    {
        CanTalk = true;
        AlreadyTalked = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp("e") && CanTalk && AlreadyTalked == false)
        {   
            CanTalk = false;
            StartCoroutine(WaitForSeconds());
           
            
        }
        if (Input.GetKeyUp("e") && CanTalk && AlreadyTalked && passcode2.Choose==false) {
            CanTalk = false;
            CanvasGroup.alpha = 1;
            text.text = " Euh... Hello again !";
            StartCoroutine(WaitSeconds());
 
        }
        if ((CanTalk && AlreadyTalked && passcode2.Choose == true && FirstTime) || (Input.GetKeyUp("e") && CanTalk && AlreadyTalked && passcode2.Choose == true))
        {
            FirstTime = false;
            CanTalk = false;
            CanvasGroup.alpha = 1;
            text.text = " Good job !";
            StartCoroutine(WaitSeconds2());

        }

    }


    IEnumerator WaitForSeconds()
    {
        
        CanvasGroup.alpha = 1;
        text.text = " Hello there ! ";
        yield return new WaitForSeconds(2);
        text.text = " My name is Kyle and I'm a super robot ! ";
        yield return new WaitForSeconds(2);
        text.text = " I love puzzles , if u solve this one I'll give u a reward ! ";
        yield return new WaitForSeconds(2);
        CanvasGroup.alpha = 0;
        CanTalk = true;
        AlreadyTalked = true;
    }
    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(2);
        text.text = " The enigma is still the same !";
        yield return new WaitForSeconds(2);
        text.text = "Just read and think";
        yield return new WaitForSeconds(2);
        CanTalk = true;
        CanvasGroup.alpha = 0;

    }
    IEnumerator WaitSeconds2()
    {
        yield return new WaitForSeconds(2);
        text.text = " Now let's try a last one ";
        yield return new WaitForSeconds(3);
        text.text = "If you don't take the right door, you will have to restart from the beginning";
        yield return new WaitForSeconds(3);
        text.text = "I am the number of primary colors, and the number of dimensions in which we live. ";
        yield return new WaitForSeconds(3);
        text.text = "I am the number of strikes you get before you're out in baseball, and the number of legs on a tripod. What am I?";
        
        yield return new WaitForSeconds(3);
        text.text = "The answer will give you the path";
        yield return new WaitForSeconds(1);
        CanvasGroup.alpha = 0;
        CanTalk = true;
    }

}
