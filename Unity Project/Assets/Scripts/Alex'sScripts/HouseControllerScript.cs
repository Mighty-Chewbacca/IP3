using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HouseControllerScript : MonoBehaviour 
{
	public GameObject[] houses;
	// Use this for initialization
	void Start () 
	{
		houses = new GameObject[transform.childCount];
		int i=0;
		foreach(Transform child in transform)
		{
			if(child.tag =="Housing")
			{
			//houses[i] = child;
			houses[i] = child.gameObject;
			i++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void ChangeRandomHouse()
	{
		int random = Random.Range (0, (transform.childCount));
		houses [random].SendMessage ("changeMesh");
	}
}
