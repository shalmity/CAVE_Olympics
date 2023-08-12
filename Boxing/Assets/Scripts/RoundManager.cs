using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public int roundLv;
    private int p1Win;
    private int p2Win;
    private float minTime;
    public float restTime;
    private float maxRestTime;
    
    public bool isRound;
    public float roundTime;

    void Start()
    {
        DontDestroyOnLoad(this);
        roundTime = 10f;
        minTime = 0f;
        p1Win = 0;
        p2Win = 0;
        restTime = 10f;
        maxRestTime = 0f;
        roundLv = 1;
        isRound = true;
    }

    void Update()
    {
        if(isRound)
        {
            //players movement on
            roundTime -= Time.deltaTime;
            if(roundTime <= minTime)
            {
                roundTime = 60f;
                isRound = false;
            }
        }
        else
        {
            //players movement off
            restTime -= Time.deltaTime;
            if(restTime <= maxRestTime)
            {
                roundLv++;
                isRound = true;
                restTime = 0;
            }
        }
    }
}
