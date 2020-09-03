using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private float Ymove;
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Ymove = Input.GetAxis("Vertical");

        transform.position += new Vector3(0, Ymove * speed * Time.deltaTime, 0);
        Mathf.Clamp(transform.position.y, -4, 4);
    }
}
