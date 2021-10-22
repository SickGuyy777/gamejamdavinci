using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int AttackDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health HitHealth = collision.GetComponent<Health>();
       if (HitHealth != null) { HitHealth.ReceiveDamage(AttackDamage); }    
    }
}
