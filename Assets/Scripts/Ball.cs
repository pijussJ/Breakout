using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;
    public Transform spawnPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var brick = collision.gameObject.GetComponent<Brick>();

        if (brick != null)
        {
            brick.Damage();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = spawnPoint.position;
        GameManager.lives--;
    }
}
