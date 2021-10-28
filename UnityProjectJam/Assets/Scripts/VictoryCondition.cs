using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public int PlayersAtEnd;
    public GameObject TxtVictory;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayersAtEnd >= 7 ) {}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayersAtEnd += 1;
    }
}
