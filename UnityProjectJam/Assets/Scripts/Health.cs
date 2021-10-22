using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int BaseHealth;
    public int CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        CurrentHealth = BaseHealth;
    }
    public void ReceiveDamage (int DamageReceived)
    {
        CurrentHealth -= DamageReceived;
        if (CurrentHealth <= 0) { Destroy(this.gameObject); }

    }
}
