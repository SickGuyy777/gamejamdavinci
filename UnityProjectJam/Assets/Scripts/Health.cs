using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int BaseHealth;
    public int CurrentHealth;
    private Animator animator;
    public int MaxHealth;
    public int MinHealth;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 150;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth < MinHealth) { CurrentHealth = MinHealth; }
        if (CurrentHealth > MaxHealth) { CurrentHealth = MaxHealth;}
        if (animator.GetBool("Death") == true) { GetComponent<CharacterMovement>().enabled = false; GetComponent<Skills>().enabled = false;}
        if (animator.GetBool("Death") == false) { GetComponent<CharacterMovement>().enabled = true; GetComponent<Skills>().enabled = true; }
    }

    private void Awake()
    {
        CurrentHealth = BaseHealth;
    }
    public void ReceiveDamage (int DamageReceived)
    {
        CurrentHealth -= DamageReceived;
        if (CurrentHealth <= 0) { animator.SetBool("Death", true); GetComponent<EnemyProjectileSpawner>().enabled = false; }
        if (CurrentHealth > 0) { animator.SetBool("Death", false);}
        
    }
}
