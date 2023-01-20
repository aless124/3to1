using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
    
{
    public Text text;
    public int score;
    public static bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        StartCoroutine(enumerator());
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : "+score;
        if (score>=100)
        {
            win = true;
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(0.5f);
        score = score + 1;
        if (score > 10 && score <= 39)
        {
            score = score + 2;
        }
        else if (score > 40 && score <= 79)
        {
            score = score + 5;
        }
        else if (score > 80)
        {
            score = score + 15;
        }
        StartCoroutine(enumerator());
    }
}
