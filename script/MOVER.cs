using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVER : MonoBehaviour
{
    //these are the variable for changing the player movement
    [SerializeField] float speed= 10f;
    int y=0;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
                
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction ()
    {
        Debug.Log("hi welcome to the game");
    }

    void MovePlayer ()
    {
         float x=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
         float z=Input.GetAxis("Vertical")*Time.deltaTime*speed;
         transform.Translate(x,y,z);        
    
    }

}
