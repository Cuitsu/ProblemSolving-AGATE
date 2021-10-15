using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBox : MonoBehaviour
{
    public GameObject Kotak;

    float randomVertical, randomHorizontal, randomTotal;

    private void Start()
    {
        randomTotal = Random.Range(5, 20);
        for (int i = 0; i < randomTotal; i++)
        {
            randomVertical = Random.Range(4f, -4f);
            randomHorizontal = Random.Range(8f, -8f);
            Instantiate(Kotak, new Vector2(randomHorizontal, randomVertical), Quaternion.identity);
        }
    }
}