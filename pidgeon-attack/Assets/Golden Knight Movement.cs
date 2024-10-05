using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKnightMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3f;
    private Vector2 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * speed;
    }
}
