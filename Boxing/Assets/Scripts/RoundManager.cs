using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoundManager : MonoBehaviourPunCallbacks, IPunObservable
{
    public int roundLv;
    private int p1Win;
    private int p2Win;
    private float minTime;
    public float restTime;
    private float maxRestTime;
    
    public bool isRound;
    public float roundTime;
    public Timer timer;
    public bool isPlayer;

    void Start()
    {
        DontDestroyOnLoad(this);
        roundTime = 10f;
        minTime = 0f;
        p1Win = 0;
        p2Win = 0;
        restTime = 10f;
        maxRestTime = 0f;
        roundLv = 0;
        isRound = false;
        isPlayer = false;
        timer = GameObject.Find("Time").GetComponent<Timer>();
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
        if(stream.IsWriting)
        {
            stream.SendNext(roundTime);
            stream.SendNext(roundLv);
            stream.SendNext(restTime);
        }
        else
        {
            roundTime = (float)stream.ReceiveNext();
            roundLv = (int)stream.ReceiveNext();
            restTime = (float)stream.ReceiveNext();
        }
    }

    void Update()
    {
        if(isPlayer)
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
}
