using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private RoundManager roundManager;
    public TMP_Text text;
    public int time;
    void Start()
    {
        roundManager = GameObject.Find("RoundManager").GetComponent<RoundManager>();
    }

    void Update()
    {
        if(roundManager.GetComponent<RoundManager>().isRound)
        {
            time = (int)roundManager.GetComponent<RoundManager>().roundTime;
            text.text = time.ToString();
        }
    }
}
