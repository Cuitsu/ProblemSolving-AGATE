using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject objectEnemy;
    private Vector2 RandomPoint;
    float RandomX, RandomY;

    // Update is called once per frame
    void Update()
    {
        EnemyMoveRandom();
        EnemyRotation();
    }

    void EnemyMoveRandom()
    {
        RandomPoint = new Vector2(RandomX,RandomY);
        transform.position = Vector2.MoveTowards(transform.position,RandomPoint,5*Time.deltaTime);
        if(Vector2.Distance(transform.position,RandomPoint) <= 0)
        {
            RandomX = Random.Range (39f, -39f);
            RandomY = Random.Range (26f, -26f);
        }
    }

    void EnemyRotation()
    {
        //arah enemy
        Vector3 enemyPos;
        Vector3 objectPos = transform.position;
        enemyPos.x = RandomX - objectPos.x;
        enemyPos.y = RandomY - objectPos.y;
        float angle = Mathf.Atan2(enemyPos.y,enemyPos.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0,0,angle + 90));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            //enemy hancur
            Destroy(gameObject);
            //bullet hancur
            Destroy(collision.gameObject);

            //dapat skor
            Score.score += 1;
        }
    }
}
