using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKnightMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3f;
    private Vector2 movementDirection;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        spriteRenderer.flipX = rb.velocity.x < 0f;
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * speed;

        //rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        //spriteRenderer.flipX = rb.velocity.x < 0f;
    }
}
