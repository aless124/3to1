using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUnit : MonoBehaviour
{
    public Dps dps;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuySquire() {
        if (dps.money >= 5) {
            dps.money -= 5;
            dps.dps += 1;
        }
        else {
            Debug.Log("Not enough money");
        }
    }
    public void BuyUnit2() {
        if (dps.money >= 15) {
            dps.money -= 15;
            dps.dps += 10;
        }
        else {
            Debug.Log("Not enough money");
        }
    }
}
