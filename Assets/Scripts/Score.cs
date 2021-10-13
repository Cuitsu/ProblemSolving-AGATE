using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scorePoint;
    public static int score;

    private void Start()
    {
        score = 0;
        scorePoint = GetComponent<Text>();
    }

    private void Update()
    {
        scorePoint.text = score.ToString();
    }
}
