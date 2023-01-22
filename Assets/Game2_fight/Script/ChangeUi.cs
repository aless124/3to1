using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class ChangeUi : MonoBehaviour
{
    public Dps dps;
    public Text moneyText;
    public Text dpsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dpsText.text =  "Dps : "+dps.dps.ToString();
        moneyText.text = "Gold : "+dps.money.ToString();
    }
}
