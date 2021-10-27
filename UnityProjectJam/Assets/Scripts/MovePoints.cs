using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoints : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform currentTarget;
    public float movementSpeed;
    public Rigidbody2D rb;

    void Start()
    {
        currentTarget = pointA;
    }

    void Update()
    {
        rb.MovePosition(Vector2.MoveTowards(rb.position, currentTarget.position, movementSpeed * Time.deltaTime));
        if (Vector2.Distance(rb.position, currentTarget.position) == 0)
        {
            if (currentTarget == pointA)
            {
                currentTarget = pointB;
            }
            else
            {
                currentTarget = pointA;
            }
        }
    }
}
