using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float Speed;
    public int FollowDistance;
    public Rigidbody2D RB;
    private Transform Target;
    public int MaxFollowDistance;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Target.position) >= FollowDistance && Vector2.Distance(transform.position, Target.position) <= MaxFollowDistance) 
        { transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime); }
        Vector3 Direction = Target.position - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        RB.rotation = angle - 90;
    }
}
