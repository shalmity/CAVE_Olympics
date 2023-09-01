using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class csPlayer : MonoBehaviourPunCallbacks
{
    //public Text NickName;
    
    void Start()
    {
        //NickName.text = photonView.IsMine ? PhotonNetwork.NickName : photonView.Owner.NickName;
        GetComponent<Renderer>().material.color = photonView.IsMine ? Color.green : Color.red;

        if (photonView.IsMine)
        {
            transform.GetChild(1).gameObject.SetActive(true);            
        } 
        //else
        //{
         //   GetComponent<Rigidbody>().detectCollisions = false;
        //}
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
            float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }
    }
}
