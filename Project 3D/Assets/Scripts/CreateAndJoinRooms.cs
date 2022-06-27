using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField createinput;
    public TMP_InputField joininput;



    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createinput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joininput.text);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("TestScene");
    }
}
