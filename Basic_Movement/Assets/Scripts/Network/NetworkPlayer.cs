using UnityEngine;
using System.Collections;

public class NetworkPlayer : Photon.MonoBehaviour
{

    public GameObject myCamera;

    bool isAlive = true;
    
  


	void Start () 
    {
    Debug.Log("I'm Alive");

        if (photonView.isMine)
        {
    

	        myCamera.SetActive(true);
	        GetComponent<player>().enabled = true;
	        GetComponent<Rigidbody>().useGravity = true;
	    }
	    else
        {
         
           
        }


    }

    void OnPhotonSerilazeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
           transform.position = (Vector3) stream.ReceiveNext();
           transform.rotation = (Quaternion) stream.ReceiveNext();
        }
        
    }
    //while alive do this state-machine
    


         
        }


