using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Completed
{

public class BoardManager : MonoBehaviour 
{
	
	[Serializable]
	public class Count 
	{
		public int minimum;
		public int maximum;
		public Count(int min, int max)
		{
			maximum = max;
			minimum = min;
		}
	}

	public int columns = 8;
	public int rows = 8;
	public Count wallCount = new Count(5,9);
	public Count footCount = new Count(1,5);
	public GameObject exit;


	public GameObject[] floorTiles;
	public GameObject[] wallTiles;
	public GameObject[] enemyTiles;
	public GameObject[] foodTiles;

	private Transform borderHolder;

	private List <Vector3> gridPositions = new List <Vector3>();

	void InitialiseList() 
	{
		gridPositions.Clear();
		
		for (int x = 1; < columns - 1; x++) 
		{
			for (int y = 1; < rows - 1; y++)
			{
				gridPositions.Add(new Vector3(x,y,0f));
			}
		}
	}



	void BoardSetup ()
	{
		boardHolder = new GameObject("Board").transform;
	

		for (int x = -1; < columns + 1; x++) 
		{
			for (int y = -1; < rows + 1; y++) 
			{
				GameObject toInstantiate = floortiles[Random.Range(0, floorTiles.Length)];
			}
		}

	}



	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
}