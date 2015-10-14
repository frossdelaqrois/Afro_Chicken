using System.Security.Cryptography;
using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

   public Vector3 speed = new Vector3(0,0,5);
   
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("key was pressed");
            transform.Translate(speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("key was pressed");
            transform.Translate(Vector3.left * Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("key was pressed");
            transform.Translate(Vector3.right * Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("key was pressed");
            transform.Translate(Vector3.back * Time.deltaTime*5);
        }

    }
}
