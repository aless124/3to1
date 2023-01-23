using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Couleur : MonoBehaviour
{
    public int Game;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {

        image.GetComponent<Image>().color = new Color32(255, 0, 0, 100);

    }

    // Update is called once per frame
    void Update()
    {
        if (Door.Game1 && Game==1)
        {
            image.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
            
        }
        if (Door.Game1 && Game == 2)  // TOURNAMENT OF POWER
        {
            image.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
        if (Score.win && Game == 3)
        {
            image.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }
}
