using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime;
    private Vector2 areaSpawn;

    // Use this for initialization
    void Start () 
    {    
        StartCoroutine(Respawnenemy());
    }

    private void Update() 
    {
        areaSpawn = new Vector2 (Random.Range(39, -39), Random.Range(26, -26));
    }
    
    private void spawnEnemy()
    {
        GameObject Enemy = Instantiate(enemyPrefab) as GameObject;
        Enemy.transform.position = areaSpawn;
    }
    IEnumerator Respawnenemy()
    {
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}