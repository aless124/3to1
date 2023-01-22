using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Random;

public class RandomSpawnScript : MonoBehaviour
{
    public int RandomInt;
    public GameObject Ennemy1;
    // Start is called before the first frame update
    void Start()
    {
        RandomInt = Random.Range(1, 3);
        Debug.Log(RandomInt);
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {    
        
    }
    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1);
        if (RandomInt == 1)
        {
            Instantiate(Ennemy1, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (RandomInt == 2)
        {
            Instantiate(Ennemy1, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
