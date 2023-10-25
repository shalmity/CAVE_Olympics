using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveEnemy : MonoBehaviour
{
    private BoxingScoreboard scoreboard;
    private bool isHit;
    private float cool;
    private void Start()
    {
        scoreboard = GetComponent<BoxingScoreboard>();
        cool = 0f;
        isHit = false;
    }
    private void Update()
    {
        if (isHit)
        {
            cool += Time.deltaTime;
            if (cool >= 0.2f)
            {
                cool = 0f;
                isHit = false;
            }

        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            isHit = true;
            scoreboard.PlayerScore--;
        }
    }
}
