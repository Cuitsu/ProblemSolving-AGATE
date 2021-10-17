using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject Kotak;

    float randomVertical, randomHorizontal, randomTotal;

    private void Start()
    {
        randomTotal = Random.Range(50,100);
        for (int i = 0; i < randomTotal; i++)
        {
            randomVertical = Random.Range(26f, -26f);
            randomHorizontal = Random.Range(39f, -39f);
            Instantiate(Kotak, new Vector2(randomHorizontal, randomVertical), Quaternion.identity);
        }
    }
}