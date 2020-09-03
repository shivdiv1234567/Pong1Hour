using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 force;
    public float speed = 5f;
    public TMP_Text scoreText;
    private int Score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        force = Vector2.one.normalized;
        
        rb.AddForce(force * speed, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Score++;
            scoreText.text = Score.ToString();
            Debug.Log(Score);
        }
    }
}
