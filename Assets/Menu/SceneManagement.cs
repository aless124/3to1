using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneManagement : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed(string scene)
    {
        if (Door.Game1 && scene == "Playground")
        {

        }
        else if (Score.win && scene == "TriangleScene")  // Condition pour vérifié que chaque if est bon   <-  utilisation d'un switch ?
        {

        }
        SceneManager.LoadScene(scene);
    }
}
