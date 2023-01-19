using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enumerator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator enumerator()
    {
        Debug.Log("Game will close");
        yield return new WaitForSeconds(5);
        
        Application.Quit();
    }
}
