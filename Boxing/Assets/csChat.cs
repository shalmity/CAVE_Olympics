using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using System.Runtime.InteropServices;


public class csChat : MonoBehaviourPunCallbacks
{
    public InputField NickNameInput;
    public InputField chatInput;
    public Text msgs;
    private RoundManager roundManager;

    public Transform summonPos1;
    public Transform summonPos2;

    public GameObject canvas;

    void Awake()
    {
        roundManager = GameObject.Find("RoundManager").GetComponent<RoundManager>();
        summonPos1 = GameObject.Find("summonPos1").GetComponent<Transform>();
        summonPos2 = GameObject.Find("summonPos2").GetComponent<Transform>();
    }

    public void Connect()
    {
        PhotonNetwork.ConnectUsingSettings();
        canvas.SetActive(false);
    }
    public override void OnConnectedToMaster()
    {
        msgs.text = "연길됨\n" + msgs.text;
        PhotonNetwork.LocalPlayer.NickName = NickNameInput.text;
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 2 }, null);
    }
    public override void OnJoinedRoom()
    {
        msgs.text = "룸에 조인됨\n" + msgs.text;
        if(PhotonNetwork.LocalPlayer.NickName == "1")
        {
            PhotonNetwork.Instantiate("Capsule", summonPos1.position, summonPos1.rotation);
            roundManager.isPlayer = true;
        }
        else if(PhotonNetwork.LocalPlayer.NickName == "2")
        {
            PhotonNetwork.Instantiate("Capsule", summonPos2.position, summonPos2.rotation);
            roundManager.isPlayer = true;
        }
    }

    public void Send()
    {
        photonView.RPC("SendMsg", RpcTarget.All, chatInput.text, NickNameInput.text);
        chatInput.Select();
        chatInput.text = "";
    }

    [PunRPC]
    void SendMsg(string msg, string sender)
    {
        msgs.text = "[" + sender + "]" + msg + "\n" + msgs.text;
    }
}