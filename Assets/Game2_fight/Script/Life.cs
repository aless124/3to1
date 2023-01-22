using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    public int life = 100;
    public Dps dps;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(lifeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator lifeCoroutine()
    {
        if (life > 0)
        {
            life = life - dps.dps;
            yield return new WaitForSeconds(1);
            StartCoroutine(lifeCoroutine());
        }
        else {
            Destroy(gameObject);
        }

    }
}
