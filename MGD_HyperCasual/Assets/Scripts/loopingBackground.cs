using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class loopingBackground : MonoBehaviour
{
    private Vector2 startPos;
    private double repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.y / 0.78;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < startPos.y - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}