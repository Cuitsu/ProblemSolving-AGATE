using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWithBoxSpawn : MonoBehaviour
{
    public GameObject Kotak;

    float randomVertical, randomHorizontal, randomTotal;

    //Rigidbody 2d bola
    private Rigidbody2D rb;

    //Besarnya gaya
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        randomTotal = Random.Range(5, 20);
        for (int i = 0; i < randomTotal; i++)
        {
            randomVertical = Random.Range(4f, -4f);
            randomHorizontal = Random.Range(8f, -8f);
            Instantiate(Kotak, new Vector2(randomHorizontal, randomVertical), Quaternion.identity);
        }
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