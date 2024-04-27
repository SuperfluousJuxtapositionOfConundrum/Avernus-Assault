using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] InputAction movement;
 
    void Start()
    {
        
    }
    void Update()
    {
        //float horizontalThrow = Input.GetAxis("Horizontal");
        //Debug.Log(horizontalThrow);
        
        //float verticalThrow = Input.GetAxis("Vertical");
        //Debug.Log(verticalThrow);
    }
}
