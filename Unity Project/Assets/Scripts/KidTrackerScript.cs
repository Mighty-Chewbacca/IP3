using UnityEngine;
using System.Collections;

public class KidTrackerScript : MonoBehaviour 
{
	//this script is simply going to contain a list of every child in the village
	//will be used by the school as well as the UI

	public static ArrayList kidList = new ArrayList (), attendingList = new ArrayList (), notAttendingList = new ArrayList ();
	public ArrayList fedTodayArray = new ArrayList(), fedYesterdayArray = new ArrayList();

	public int kidsAttending, kidsNotAttending, totalKids;
	private KidScript currentKid;
	private SchoolScript currSchool;

	// Use this for initialization
	void Start () 
	{
		currSchool = GameObject.FindGameObjectWithTag("School").GetComponent<SchoolScript>();

		foreach(GameObject kid in GameObject.FindGameObjectsWithTag("Housing"))
		{
			kidList.Add(kid.GetComponent<KidScript>());
			//Debug.Log(kidList.Count);
		}

		foreach (KidScript kid in kidList)
		{
			//Debug.Log(kid.getGoingToSchool());
			
			if (kid.getGoingToSchool() == true)
			{
				attendingList.Add(kid);
			}
			else
			{
				notAttendingList.Add(kid);
			}
		}

		//updateLists ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		kidsAttending = attendingList.Count;
		kidsNotAttending = notAttendingList.Count;
		totalKids = kidList.Count;
	}

	public void getNewAttendee()
	{
		if (notAttendingList.Count != 0) 
		{
			currentKid = notAttendingList [0] as KidScript;
			notAttendingList.RemoveAt(0);
			currentKid.setGoingToSchool (true);
			currentKid.fedToday = true;
			currentKid.fedYesterday = true;
			attendingList.Add(currentKid);
		}
	}

	public void removeAttendee()
	{
		if (attendingList.Count != 0) 
		{
			currentKid = attendingList [0] as KidScript;
			attendingList.RemoveAt(0);
			currentKid.setGoingToSchool (false);
			notAttendingList.Add(currentKid);
		}
	}

	public void checkKidsFood()
	{
		//loop through attending list.
		//keep setting the kids to fed for today until we reach too many for the stored food
		//also need to set the value for fed yesterday to the fed today option before setting fed today

		ArrayList removedPupils = new ArrayList ();

		foreach (KidScript kid in attendingList)
		{	
			kid.WasFedYesterday(kid.getWasFedToday());

			if (currSchool.getMealsStored() > 0)
			{
				kid.WasFedToday(true);
				currSchool.setMealsStored(currSchool.getMealsStored() - 1);
			}
			else
			{
				kid.WasFedToday(false);
			}
		}

		foreach (KidScript kid in notAttendingList)
		{	
			kid.WasFedYesterday(kid.getWasFedToday());
			kid.WasFedToday(false);
		}

		foreach (KidScript kid in attendingList)
		{	
			if (kid.getWasFedToday() == false && kid.getWasFedYesterday() == false) // and its not hte kids first day - still to implement
			{
				//attendingList.Remove(kid);
				kid.setGoingToSchool (false);
				notAttendingList.Add(kid);
				removedPupils.Add(kid);
			}
		}

		foreach(KidScript kid in removedPupils)
		{
			attendingList.Remove (kid);
		}
	}

	public void CheckIfSchoolEligable ()
	{
		int kidCount = 0;

		if (attendingList.Count != 0) 
		{
			foreach (KidScript kid in attendingList) 
			{
				
				if (kid.fedToday == true && kid.fedYesterday == true) 
				{
					kidCount++;
				} 
			}

			if (kidCount == attendingList.Count)
			{
				currSchool.eligableForNewPupil = true;
			}
			else
			{
				currSchool.eligableForNewPupil = false;
			}
		}

		if (attendingList.Count == 0)
		{
			currSchool.eligableForNewPupil = true;
		}
	}
}
