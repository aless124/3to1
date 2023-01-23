using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public Dps dps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dps.dps >= 1000) {
            Debug.Log("You win");
            SceneManager.LoadScene("Menu");
        }
    }
}
