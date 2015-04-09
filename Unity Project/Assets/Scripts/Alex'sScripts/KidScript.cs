using UnityEngine;
using System.Collections;

public class KidScript : MonoBehaviour 
{
	//this script is going to represent a kid
	//will hold wether or not the kid will be at school or not

	public bool goingToSchool = false;
	private bool isFed = false;
	private bool isWatered = false;
	public bool fedYesterday, fedToday;

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

	public void WasFedToday(bool wasfed)
	{
		fedToday = wasfed;
	}

	public void WasFedYesterday(bool wasfed)
	{
		fedYesterday = wasfed;
	}

	public bool getWasFedToday()
	{
		return fedToday;
	}

	public bool getWasFedYesterday()
	{
		return fedYesterday;
	}
}
