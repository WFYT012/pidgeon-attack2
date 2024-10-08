using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigeon : MonoBehaviour
{
    public GameObject GoldenKnight;
    public float speed;
    private SpriteRenderer spriteRenderer;
    Rigidbody2D rb;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, GoldenKnight.transform.position);
        Vector2 direction = GoldenKnight.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, GoldenKnight.transform.position, speed * Time.deltaTime);

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        spriteRenderer.flipX = rb.velocity.x < 0f;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(other.gameObject);

    }

    
}
