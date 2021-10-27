using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeUnlocking : MonoBehaviour
{
    private Transform BridgePosition;
    BoxCollider2D BridgeCollider;
    public float LeverMaxDistance; 
    // Start is called before the first frame update
    void Start()
    {
        BridgeCollider = GameObject.FindGameObjectWithTag("Bridge").GetComponent<BoxCollider2D>();
        BridgePosition = GameObject.FindGameObjectWithTag("Bridge").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown("g") && Vector2.Distance(transform.position, BridgePosition.position) <= LeverMaxDistance)
        {
            BridgeCollider.enabled = false;
        }
    }
}
