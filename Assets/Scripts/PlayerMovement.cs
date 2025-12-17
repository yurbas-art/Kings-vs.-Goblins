using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10;
    private Vector2 moveVector;
    private SpriteRenderer sr;
    [SerializeField] private Joystick _joystick;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {        
        moveVector.x = _joystick.Horizontal;
        moveVector.y = _joystick.Vertical;        
        if (moveVector.x > 0)
        {
            sr.flipX = true;
        }
        else if (moveVector.x < 0)
        {
            sr.flipX = false;
        }
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
        
    }
}
