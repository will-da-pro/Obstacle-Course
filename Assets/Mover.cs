using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    float inertiaX = 0f;
    float inertiaZ = 0f;
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
        if (xValue != 0f)
        {
            if (inertiaX == 0f)
            {
                inertiaX = 0.01f;
            }
            else
            {
                if (inertiaX <= 1f)
                {
                    inertiaX += 0.01f;
                }
                xValue = xValue * inertiaX;
            }
        }
        else if (zValue != 0f)
        {
            if (inertiaZ == 0f)
            {
                inertiaZ = 0.01f;
            }
            else
            {
                if (inertiaZ <= 1f)
                {
                    inertiaZ += 0.01f;
                }
                zValue = zValue * inertiaZ;
            }
        }
        transform.Translate(xValue, 0, zValue);
    }
}
