using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Movement : MonoBehaviour
{
    public Rigidbody2D Myrigidbody2D;
    public float BulletSpeed;
    public float Lifetime;

    // Start is called before the first frame update
    void Start()
    {
        Myrigidbody2D.AddForce(transform.right * BulletSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Lifetime -= Time.deltaTime;
        if (Lifetime <= 0) { Destroy(this.gameObject); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
