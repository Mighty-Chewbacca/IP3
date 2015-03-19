using UnityEngine;
using System.Collections;

public class SchoolScript : MonoBehaviour 
{
	//this script will represent the school that the kids will attend, it will have a population attending it
	//it will also have hunger and thirst levels

	private int attendingPopulation;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	//set the new number of pupils
	public void setAttendingPopulation(int newPop)
	{
		attendingPopulation = newPop;
	}

	//get the current amount of pupils
	public int getAttendingPopulation()
	{
		return attendingPopulation;
	}

	//add a new pupil to the school
	public void addNewPupil()
	{
		attendingPopulation++;
	}

	//take on pupil away from the school
	public void removePupil()
	{
		attendingPopulation --;
	}
}
