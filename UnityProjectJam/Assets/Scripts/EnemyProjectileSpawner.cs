using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileSpawner : MonoBehaviour
{
    public float CurrentAttackCooldown;
    public float AttackCooldown;
    public GameObject Bala;
    public SpriteRenderer SR;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CurrentAttackCooldown -= Time.deltaTime; 
        if (CurrentAttackCooldown <= 0)
        {
            animator.SetTrigger("Skill");
            GameObject BalaInstance = Instantiate(Bala, transform.position, Quaternion.identity); CurrentAttackCooldown = AttackCooldown;
            if (SR.flipX == true) { BalaInstance.transform.right = transform.right; }
            else { BalaInstance.transform.right = -transform.right; }
        }
    }
}
