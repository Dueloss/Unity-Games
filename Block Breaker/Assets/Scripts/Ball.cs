﻿using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;
    private Rigidbody2D regi;

    private void Awake()
    {
        regi = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mouse Click");
                hasStarted = true;
                regi.velocity = new Vector2(2f, 10f);

            }
        }
    }
}
