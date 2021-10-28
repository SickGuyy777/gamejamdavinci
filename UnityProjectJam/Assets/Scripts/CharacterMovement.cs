using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float MovementSpeed;
    public SpriteRenderer SR;
    private Animator animator;
    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.freezeRotation = true;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 InputVector;
        InputVector.x = Input.GetAxis("Horizontal");
        InputVector.y = Input.GetAxis("Vertical");
        InputVector.z = 0f;
        transform.position += InputVector * Time.deltaTime * MovementSpeed;
        if (InputVector.x < 0) { SR.flipX = false; } 
        
        if (InputVector.x > 0) { SR.flipX = true;}
        
        if (InputVector.x != 0 || InputVector.y != 0) { animator.SetBool("Run", true); }
        else { animator.SetBool("Run", false); }
        if (Input.GetKeyDown("p")) { RB.simulated = false; }
        if (Input.GetKeyDown("o")) { RB.simulated = true; }
    }
    
}
