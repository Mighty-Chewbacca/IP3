using UnityEngine;
using System.Collections;

public class SchoolScript : MonoBehaviour 
{
	//this script will represent the school that the kids will attend, it will have a population attending it
	//it will also have hunger and thirst levels

	private int attendingPopulation;
	private int mealsNeeded;
	public int mealsStored;
	public int drinksStored;
	private int drinksNeeded;

	// Use this for initialization
	void Start () 
	{
		attendingPopulation = KidTrackerScript.attendingList.Count;
		Debug.Log ("Attending Population" + attendingPopulation);
	}
	
	// Update is called once per frame
	void Update () 
	{
		mealsNeeded = attendingPopulation;
		// check for the correct amount of meals every 24 hours - 96 ticks!

	}

	//add meals to the storage
	public void addMeals(int amount)
	{
		mealsStored += amount;
	}

	#region get set attending pupils
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
	#endregion

	#region add remove pupils
	//add a new pupil to the school
	public void addNewPupil()
	{
		attendingPopulation++;
	}

	//take one pupil away from the school
	public void removePupil()
	{
		attendingPopulation --;
	}
	#endregion

	#region get set meals needed
	//set the number of meals needed today
	//should be equal to one per pupil
	public void setMealsNeeded(int newVal)
	{
		mealsNeeded = newVal;
	}

	//get the number of meals the school will need today
	//this is equal to one per pupil
	public int getMealsNeeded()
	{
		return mealsNeeded;
	}
	#endregion

	#region get set meals stored
	//set the number of meals stored
	public void setMealsStored(int newVal)
	{
		mealsStored = newVal;
	}

	//get the amount of meals the school has stored
	public int getMealsStored()
	{
		return mealsStored;
	}
	#endregion
}
