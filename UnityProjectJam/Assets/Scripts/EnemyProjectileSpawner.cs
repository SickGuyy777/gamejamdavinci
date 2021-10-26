using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileSpawner : MonoBehaviour
{
    public float CurrentAttackCooldown;
    public float AttackCooldown;
    private Transform Target;
    public float AttackRange;
    public GameObject Bala;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentAttackCooldown -= Time.deltaTime; 
        if (Vector2.Distance(transform.position, Target.position) <= AttackRange && CurrentAttackCooldown <= 0)
        {
            GameObject BalaInstance = Instantiate(Bala, transform.position, Quaternion.identity); CurrentAttackCooldown = AttackCooldown;
            BalaInstance.transform.right = transform.up;
        }
    }
}
