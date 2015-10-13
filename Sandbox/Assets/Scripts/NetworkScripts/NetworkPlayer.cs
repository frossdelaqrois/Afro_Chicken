using System.IO;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using System.Collections;

public class NetworkPlayer : Photon.MonoBehaviour
{

    public GameObject myCamera;
    private Vector3 correntPlayerPos;
    private Quaternion correctPlayerRot;


	// Use this for initialization
	void Start()
	{
	    if (photonView.isMine)
	    {
            myCamera.SetActive(true);
            GetComponent<PlayerControl>().enabled = true;
	        GetComponent<Rigidbody>().useGravity = true;
	    }
	    else
	    {
	        
	    }
       
	}

    void OnPhotonSerializedView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            //Network player, receiced data
            transform.position = (Vector3)stream.ReceiveNext();
            transform.rotation = (Quaternion)stream.ReceiveNext();

        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
