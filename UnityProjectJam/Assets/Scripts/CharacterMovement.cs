using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float MovementSpeed;
    public SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 InputVector;
        InputVector.x = Input.GetAxis("Horizontal");
        InputVector.y = Input.GetAxis("Vertical");
        InputVector.z = 0f;
        transform.position += InputVector * Time.deltaTime * MovementSpeed;
        if (Input.GetKey("a")) { SR.flipX = false; }
        if (Input.GetKey("d")) { SR.flipX = true; }
    }
}
