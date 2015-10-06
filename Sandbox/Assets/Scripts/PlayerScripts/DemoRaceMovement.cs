using UnityEngine;
using System.Collections;

public class DemoRaceMovement : MonoBehaviour 
{
    public ThirdPersonOrbitCam Camera;

    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
        Vector3 position = new Vector3( 0f, 0f, 0f );

        GameObject newPlayerObject = PhotonNetwork.Instantiate( "Chicken", position, Quaternion.identity, 0 );

       
    }
}
