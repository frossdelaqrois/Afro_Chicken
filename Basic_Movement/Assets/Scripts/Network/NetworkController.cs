using UnityEngine;
using System.Collections;

public class NetworkController : MonoBehaviour
{

    public string Room = "Start";
    public string PlayerPrefabName = "NetworkPlayer";
    public Transform SpawnPoint;

	// Use this for initialization
	void Start ()
	{
	    PhotonNetwork.ConnectUsingSettings("0.1");
	}

    void OnJoinedLobby()
    {
        Debug.Log("joined lobby");

        RoomOptions roomOptions = new RoomOptions() {isVisible = true, maxPlayers = 4};
        PhotonNetwork.JoinOrCreateRoom(Room, roomOptions, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("NetworkPlayer", SpawnPoint.position, SpawnPoint.rotation, 0);
    }
}
