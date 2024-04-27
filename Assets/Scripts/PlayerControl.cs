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
        float horizontalThrow = movement.ReadValue<Vector2>().x;

        //float horizontalThrow = Input.GetAxis("Horizontal");
        Debug.Log(horizontalThrow);

        float verticalThrow = movement.ReadValue<Vector2>().y;
        
        //float verticalThrow = Input.GetAxis("Vertical");
        Debug.Log(verticalThrow);
    }

    void OnEnable()
    {
        movement.Enable();
    }

    void OnDisable()
    {
        movement.Disable();
    }
}
