using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModelTurn : MonoBehaviour
{
    float speed = 1f;
    float test = 10f;
    float speed2 = 50;
    public float jump;
    public GameObject Triangle;
    private bool fall = false;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enumerator());
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("s") && fall == false) || fall==true) 
        {

            if (rigidbody.transform.position.y >= 2.5f )
            {
                SceneManager.LoadScene("LoseScreen");
            }
            else
            {
                fall = true;
                rigidbody.transform.Translate(Vector3.down * test *Time.deltaTime, Space.World);
            }
                  //Move the Rigidbody downwards constantly at the speed you define (the green arrow axis in Scene view)
            
            
        }
            //rotate the sprite about the Z axis in the positive direction           
                Triangle.transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed2, Space.World);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
            fall = false;
            rigidbody.velocity = transform.up * jump;
            Debug.Log("jump");
        Vector3 velocity = rigidbody.velocity;
        rigidbody.velocity = new Vector3(velocity.x, 2, velocity.z);
        speed2 = speed2 + 5;


    }
    IEnumerator enumerator()
    {
        
        yield return new WaitForSeconds(1);
        if (speed <= 10)
        {
            speed = speed + 0.02f;
            StartCoroutine(enumerator());
        }
    }

}
