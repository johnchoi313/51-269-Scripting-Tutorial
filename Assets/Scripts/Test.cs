using UnityEngine;
using System.Collections.Generic;

public class Test : MonoBehaviour
{   
    public Move moveScript;
    public GameObject thisIsAGameObject;
    public Transform thisIsATransform;
    public float rotationSpeed = 90f; // Degrees per second

    /*
    public List<float> thisIsAListOfFloats = new List<float>();
    
    public float moveSpeed = 10f;
    public bool thisIsABoolean = true;
    public string thisIsAString = "Hello, World!";
    public int thisIsAnInteger = 10;
    public float thisIsAFloat = 10.5f;
    public double thisIsADouble = 10.5;
    public char thisIsACharacter = 'A';
    */

    // hello
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveScript.MoveMe();
        }
        if (Input.GetKey(KeyCode.A))
        {
            thisIsATransform.Translate(1*Time.deltaTime, 0, 0);
        }

    }
}
