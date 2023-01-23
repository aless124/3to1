using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public RandomSpawnScript Dead;
    public int life = 100;
    public Dps dps;
    public TextMesh lifeText;
    // Start is called before the first frame update
    void Start()
    {
        dps = GameObject.Find("ScriptManager").GetComponent<Dps>();
        Dead = GameObject.Find("ScriptManager").GetComponent<RandomSpawnScript>();

        StartCoroutine(lifeCoroutine());
        
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = " Hp : " +life.ToString();
    }
    IEnumerator lifeCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        if (life-dps.dps > 0)
        {

            life = life - dps.dps;
            

            StartCoroutine(lifeCoroutine());
        }
        else {
            Dead.dead = true;
            Destroy(gameObject);
        }

    }
}
