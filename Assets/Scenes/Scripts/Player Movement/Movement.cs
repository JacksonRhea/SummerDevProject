using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{

    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();


    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        GetMovement();

    }

    private void GetMovement()
    {
        Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        OnMove?.Invoke(movementVector.normalized);
    }

}
