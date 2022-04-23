using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Seconds before object drops
    [SerializeField] float waitTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime) 
        {
            Debug.Log("Drop!");
        }
    }
}
