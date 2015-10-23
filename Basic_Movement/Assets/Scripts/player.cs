using System.Security.Cryptography;
using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    public Vector3 speed = new Vector3(0, 0, 5);
    public Vector3 jump = new Vector3(0, 5, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("W key was pressed");
            transform.Translate(speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("A key was pressed");
            transform.Translate(Vector3.left * Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("D key was pressed");
            transform.Translate(Vector3.right * Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("S key was pressed");
            transform.Translate(Vector3.back * Time.deltaTime*5);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("S key was pressed");
            transform.Translate(jump * Time.deltaTime * 15);
        }

    }
}
