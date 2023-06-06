using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Rigidbody2D rigid;
    private Vector2 movementVector;
    public float maxSpeed = 10;
    public float rotation = 100;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void HandleMoveBody(Vector2 movementVector)
    {
        this.movementVector = movementVector;
    }

    private void FixedUpdate()
    {
        rigid.velocity = (Vector2)transform.up * movementVector.y * maxSpeed * Time.deltaTime;
        rigid.MoveRotation(transform.rotation * Quaternion.Euler(0, 0, -movementVector.x * rotation * Time.fixedDeltaTime));
    }

}
