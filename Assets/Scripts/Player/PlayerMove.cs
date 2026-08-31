using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField]GameObject player;
    private Rigidbody2D rb;
    Vector2 moveInput;
    Boolean isJumping = false;
    
    private void Awake()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput.x * speed, rb.linearVelocity.y);
    }
    
    void OnJump(InputValue inputValue)
    {
        if (inputValue.isPressed && rb.linearVelocity.y == 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 10f);
        }
    }

    void OnMove(InputValue inputValue)
    {
        moveInput = inputValue.Get<Vector2>();
        SpriteRenderer spriteRenderer = player.transform.GetChild(0).GetComponent<SpriteRenderer>();
        if (moveInput.x < 0 && spriteRenderer != null)
        {
            player.transform.GetChild(0);
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
