using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome To The Game");
        Debug.Log("Your player's name is Peridot!");
        Debug.Log("Your task: Guide your player through the maze using the directional arrow keys");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
