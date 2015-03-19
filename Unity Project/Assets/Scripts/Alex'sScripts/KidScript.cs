using UnityEngine;
using System.Collections;

public class KidScript : MonoBehaviour 
{
	//this script is going to represent a kid
	//will hold wether or not the kid will be at school or not

	private bool goingToSchool = false;

	SchoolScript mySchool;

	// Use this for initialization
	void Start () 
	{
		mySchool = GameObject.FindGameObjectWithTag("School").GetComponent<SchoolScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public bool getGoingToSchool()
	{
		return goingToSchool;
	}

	public void setGoingToSchool(bool newVal)
	{
		goingToSchool = newVal;
	}
}
