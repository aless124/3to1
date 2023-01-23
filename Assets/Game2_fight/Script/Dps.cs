using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Dps : MonoBehaviour
{
    public int dps;
    public int money;
    public int Change;
    // Start is called before the first frame update
    void Start()
    {
        dps = 0;
        money = 0;
        Change = 1;
        StartCoroutine(MoneyEnumerator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MoneyEnumerator ()
    {
        money = money + Change;
        yield return new WaitForSeconds(1);
        StartCoroutine(MoneyEnumerator());
    }
}
