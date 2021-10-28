using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public int PlayersAtEnd;
    public GameObject TxtVictory;

    void Start()
    {
    }

    void Update()
    {
        if (PlayersAtEnd >= 7 )
        {
            TxtVictory.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayersAtEnd += 1;
    }
}
