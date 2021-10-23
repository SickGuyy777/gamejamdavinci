using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public static int CharacterPlaying;
    public static float Timer;
    public float BaseTime;
    public int PlayerNumber;
    private GameObject Target;
    private Vector3 Cameraposition;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        Cameraposition.x = transform.position.x;
        Cameraposition.y = transform.position.y;
        Cameraposition.z = -10;
        Timer -= Time.deltaTime;
        if (CharacterPlaying == 8) { CharacterPlaying = 0;}
        if (Timer <= 0) { CharacterPlaying += 1; Timer = BaseTime; }
        if (CharacterPlaying != PlayerNumber) {GetComponent<CharacterMovement>().enabled = false; GetComponent<Skills>().enabled = false; }
        if (CharacterPlaying == PlayerNumber) { GetComponent<CharacterMovement>().enabled = true; GetComponent<Skills>().enabled = true; Target.transform.position = Cameraposition; }
        if (CharacterPlaying == 8) { CharacterPlaying = 1; }
    }
}
