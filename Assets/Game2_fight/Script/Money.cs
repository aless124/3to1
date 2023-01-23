using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public Dps money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMineV1() {
         if (money.money >= 15) {
            money.money = money.money - 15;
            money.Change +=1;

         }
            else {
                Debug.Log("Not enough money");
            }
    }
    public void AddMineV2() {
            if (money.money >= 50) {
                money.money = money.money - 50;
                money.Change +=5;
    
            }
                else {
                    Debug.Log("Not enough money");
                }
    }
}
