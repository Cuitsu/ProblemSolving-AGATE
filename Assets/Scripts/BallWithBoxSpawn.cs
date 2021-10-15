using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWithBoxSpawn : MonoBehaviour
{
    //Rigidbody 2d bola
    private Rigidbody2D rb;

    //Besarnya gaya
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Gerakan bola
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(collision.gameObject);
            Score.score += 1;
        }
    }
}