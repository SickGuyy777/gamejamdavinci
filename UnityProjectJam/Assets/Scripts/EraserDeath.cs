using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserDeath : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("Death") == true) { GetComponent<MovePoints>().enabled = false; GetComponent<Damage>().enabled = false; }
    }
}
