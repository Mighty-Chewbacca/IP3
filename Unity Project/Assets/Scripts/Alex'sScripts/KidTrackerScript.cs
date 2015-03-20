using UnityEngine;
using System.Collections;

public class KidTrackerScript : MonoBehaviour 
{
	//this script is simply going to contain a list of every child in the village
	//will be used by the school as well as the UI

	public static ArrayList kidList, attendingList, notAttendingList;
	public int kidsAttending, kidsNotAttending, totalKids;

	// Use this for initialization
	void Start () 
	{
		kidList = new ArrayList ();
		attendingList = new ArrayList ();
		notAttendingList = new ArrayList ();

		foreach(GameObject kid in GameObject.FindGameObjectsWithTag("Housing"))
		{
			kidList.Add(kid.GetComponent<KidScript>());
			Debug.Log(kidList.Count);
		}

		updateLists ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		kidsAttending = attendingList.Count;
		kidsNotAttending = notAttendingList.Count;
		totalKids = kidList.Count;
	}

	//this method will be used to update the attending and non attending lists
	void updateLists()
	{
		foreach (KidScript kid in kidList)
		{

			Debug.Log(kid.getGoingToSchool());

			if (kid.getGoingToSchool() == true)
			{
				attendingList.Add(kid);
				if (notAttendingList.Contains(kid))
				{
					notAttendingList.Remove(kid);
				}
			}
			else
			{
				notAttendingList.Add(kid);
				
				if (attendingList.Contains(kid))
				{
					attendingList.Remove(kid);
				}
			}
		}
	}
}
