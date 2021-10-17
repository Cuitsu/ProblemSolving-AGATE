using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCount : MonoBehaviour
{
    private Text bulletPoint;
    public static int point;

    private void Start()
    {
        point = 0;
        bulletPoint = GetComponent<Text>();
    }

    private void Update()
    {
        bulletPoint.text = point.ToString();
    }
}
