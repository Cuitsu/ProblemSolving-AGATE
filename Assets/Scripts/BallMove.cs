using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    //Rigidbody 2d bola
    private Rigidbody2D rb;

    //Besarnya gaya
    public float xInitialForce;
    public float yInitialForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PushBall();
    }

    //Dorong bola
    void PushBall()
    {
        rb.AddForce(new Vector2(xInitialForce, yInitialForce));
    }
}