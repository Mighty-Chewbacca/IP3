using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HouseControllerScript : MonoBehaviour 
{
	public ArrayList houseList = new ArrayList();
	// Use this for initialization
	void Start () 
	{
		foreach(Transform child in transform)
		{
			if(child.tag =="Housing")
			{
				houseList.Add(child.GetComponent<ModelChangerScript>());
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public int CheckHighestUpgrade()
	{
		int highestUpgrade = 0;
		foreach (ModelChangerScript house in houseList)
		{
			if (house.getHouseLevel() > highestUpgrade)
			{
				highestUpgrade = house.getHouseLevel();
			}
		}

		Debug.Log ("the highest upgrade is" + highestUpgrade);
		return highestUpgrade;
	}

	public int CheckLowestUpgrade()
	{
		int lowestUpgrade = 1000;
		foreach (ModelChangerScript house in houseList)
		{
			if (house.getHouseLevel() < lowestUpgrade)
			{
				lowestUpgrade = house.getHouseLevel();
			}
		}

		Debug.Log ("the lowest upgrade is" + lowestUpgrade);
		return lowestUpgrade;
	}

	public void CheckIfCanUpgrade()
	{

	}
}
