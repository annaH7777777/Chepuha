using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonServer : MonoBehaviourPunCallbacks
{
    GameManager gameManager;
    int prefabIndex = 0;
    public delegate void EpisodeActivation(int prefabIndex);
    public static event EpisodeActivation OnEpisodeActivation; 

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        PhotonNetwork.ConnectUsingSettings();
        //PhotonNetwork.OnConnectedToMaster += JoinRoom;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room 1", new RoomOptions(), null, null);
        Debug.Log("On connected to master");
    }

    [PunRPC]
    private void IncreacePlayersCount()
    {
        prefabIndex = PhotonNetwork.CountOfPlayersInRooms + 1;
        //prefabIndex = PhotonNetwork.CurrentRoom.PlayerCount + 1;
        Debug.Log("players " + prefabIndex);
    }
    public override void OnJoinedRoom()
    {
        IncreacePlayersCount();
        OnEpisodeActivation(prefabIndex);
        Debug.Log("On joined room " + prefabIndex);
    }
}
