using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R : MonoBehaviour
{
    public AudioSource Rick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("r")) { Rick.Play(); }
        if (Input.GetKeyDown("u")) { Rick.Stop(); }
    }
}
