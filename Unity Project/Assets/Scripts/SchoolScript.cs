using UnityEngine;
using System.Collections;

public class SchoolScript : MonoBehaviour 
{
	//this script will represent the school that the kids will attend, it will have a population attending it
	//it will also have hunger and thirst levels

	public int attendingPopulation, nonAttendingPopulation;
	private int mealsNeeded;
	public int mealsStored;
	public bool eligableForNewPupil = true;

	public int educationSupplies;

	private int currentTick, desiredTickWeek, desiredTickDay;

	private EconomyScript econ;
	private KidTrackerScript kidTracker;

	// Use this for initialization
	void Start () 
	{
		econ = GameObject.Find("Main Camera").GetComponent<EconomyScript>();
		kidTracker = GameObject.Find("Main Camera").GetComponent<KidTrackerScript>();

		desiredTickWeek = 192; //now 2 days not week
		desiredTickDay = 10;

		attendingPopulation = KidTrackerScript.attendingList.Count;
		Debug.Log ("Attending Population" + attendingPopulation);

	}
	
	// Update is called once per frame
	void Update () 
	{
		attendingPopulation = kidTracker.kidsAttending;
		nonAttendingPopulation = kidTracker.kidsNotAttending;
		Debug.Log ("eligible for pupil   " + eligableForNewPupil);
		currentTick = econ.GetCurrentTick();

		if (currentTick == desiredTickWeek)
		{
			//check if the kids have all been fed
			kidTracker.CheckIfSchoolEligable();
			//if they have, enrol a new one
			if (eligableForNewPupil)
			{
				kidTracker.getNewAttendee();
			}

			desiredTickWeek = currentTick += 192; // setting up the checking once every 2 days structure, will check at half 8 in the morning every 2 days
		}

		if (currentTick == desiredTickDay)
		{
			//check if there are enough meals for the kids today
			kidTracker.CheckIfSchoolEligable();
			kidTracker.checkKidsFood();

			if (eligableForNewPupil)
			{
				kidTracker.getNewAttendee();
			}
			desiredTickDay = currentTick += 10; // setting up the checking once a day structure, will check at half 8 in the morning every day
		}

		mealsNeeded = attendingPopulation;
		// if a week has passed then check if we need to enrol another kid, 672 ticks in a week
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
