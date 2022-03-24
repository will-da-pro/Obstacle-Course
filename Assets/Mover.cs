using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    float inetiaX = 0;
    float inertiaY = 0;
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
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the WASD or Arrow keys to move, ");
        Debug.Log("and don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        if xValue >=0 
        {
            if inertiaX == 0 
            {
                inertiaX = 0.1
            }
            else
            {
                xValue = xValue * inertiaX;
            }
        }
        transform.Translate(xValue, 0, zValue);
    }
}
