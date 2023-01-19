using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{
    
    public Transform PlayerTransform;
    private int speed = 1;
    private int sprint = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        PlayerTransform = GameObject.Find("PlayerCapsule").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d"))
        {
            PlayerTransform.Translate(Vector3.right * Time.deltaTime * speed);
            if (Input.GetKey("left shift") )
            {
                PlayerTransform.Translate(Vector2.right * Time.deltaTime * sprint);
        
            }
        }
        if (Input.GetKey("z"))
        {
            PlayerTransform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (Input.GetKey("left shift"))
            {
                PlayerTransform.Translate(Vector3.forward * Time.deltaTime * sprint);
            
            }
        }
        if (Input.GetKey("q"))
        {
            PlayerTransform.Translate(Vector3.left * Time.deltaTime * speed);
            if (Input.GetKey("left shift"))
            {
                PlayerTransform.Translate(Vector3.left * Time.deltaTime * sprint);
       
            }
        }
        if (Input.GetKey("s"))
        {
            PlayerTransform.Translate(Vector3.back * Time.deltaTime * speed);
            if (Input.GetKey("left shift") )
            {
                PlayerTransform.Translate(Vector3.back * Time.deltaTime * sprint);
            }
        }
    }
}
