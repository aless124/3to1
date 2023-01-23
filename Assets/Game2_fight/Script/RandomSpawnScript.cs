using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Random;

public class RandomSpawnScript : MonoBehaviour
{
    public int RandomInt;
    public bool dead;
    public bool FirstTime;
    public GameObject Ennemy1;
    public GameObject Ennemy2;
    public GameObject Ennemy3;
    // Start is called before the first frame update
    void Start()
    {
        
        FirstTime = false;
        StartCoroutine(FirstEnnemy());
        dead = true;
    }

    // Update is called once per frame
    void Update()
    {    
        
    }

    IEnumerator FirstEnnemy() 
    {
        yield return new WaitForSeconds(1);
        if  (FirstTime == false & dead == true)
        {
            
            Instantiate(Ennemy1, new Vector3(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            FirstTime = true;
            dead = false;
        }
        
        yield return new WaitForSeconds(5);
        if (dead == true & FirstTime == true) {
            StartCoroutine(SpawnEnemy());
        }
        else {
            Debug.Log("FirstEnnemy not dead");
            if(dead == false & FirstTime == true) {
                StartCoroutine(FirstEnnemy());
            }
        }
        
        

        
    }

    IEnumerator SpawnEnemy()
    {
       RandomInt = Random.Range(1, 5);
       yield return new WaitForSeconds(1);
        if  (dead == true)
        {

            yield return new WaitForSeconds(1);
            if (RandomInt == 1)
            {
                Debug.Log("SpawnEnemy 1");
                dead = false;
                Instantiate(Ennemy1, new Vector3(0, 0, 0), Quaternion.identity);
                

            }
            else if (RandomInt == 2)
            {
                Debug.Log("SpawnEnemy 2");
                dead = false;
                Instantiate(Ennemy2, new Vector3(0, 0, 0), Quaternion.identity);
                
            }
            /*else if (RandomInt == 3) 
            {
                Instantiate(Ennemy1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(Ennemy2, new Vector3(0, 0, 0), Quaternion.identity);
                Dead = false;
            }*/
            else if (RandomInt == 4) {
                Debug.Log("SpawnEnemy 3");
                dead = false;
                Instantiate(Ennemy3, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnEnemy());
    }

}
