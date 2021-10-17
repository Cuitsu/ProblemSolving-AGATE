using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //foodnya
    public GameObject Kotak;

    //Enemy
    public GameObject Enemy;

    //peluru
    public GameObject bullet;
    int jumlahBullet;

    //Rigidbody 2d head
    private Rigidbody2D rb;

    //Besarnya gaya
    public float speed;
    public float rotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Gerakan bola
    void Update()
    {
        //input mouse
        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), speed * Time.deltaTime);

        //arah player
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;
        float angle = Mathf.Atan2(mousePos.y,mousePos.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0,0,angle + rotationOffset));

        //menembak
        if(Input.GetMouseButtonDown(0))
        {
            if(jumlahBullet > 0)
            {
                Instantiate(bullet,transform.position,Quaternion.identity);
                jumlahBullet--;
                BulletCount.point -= 1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            //makanan hancur
            Destroy(collision.gameObject);
            
            //dapat bullet
            jumlahBullet++;
            BulletCount.point += 1;

            StartCoroutine(RespawnFood(collision.gameObject));
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            //makanan hancur
            Destroy(gameObject);

            //gameover

        }
    }

    IEnumerator RespawnFood (GameObject prefab)
    {
        yield return new WaitForSeconds(3f);
        Instantiate(Kotak, new Vector2 (Random.Range(39f, -39f), Random.Range(26f, -26f)), Quaternion.identity);
    }
}