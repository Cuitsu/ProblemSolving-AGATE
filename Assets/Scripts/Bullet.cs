using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, dir ,10 * Time.deltaTime);
        if(Vector2.Distance(transform.position,dir) <= 0)
        {
            Destroy(gameObject);
        }
    }
}
