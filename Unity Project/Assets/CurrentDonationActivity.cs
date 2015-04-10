using UnityEngine;
using System.Collections;

public class CurrentDonationActivityScript : MonoBehaviour 
{
	//there will only be one of these available at once
	//it will be the current fundraising activity and will control all sorts to do with that!
	private EconomyScript econ;
	
	private bool isActive = false;
	
	private int timeToCompleteActivity;
	private int desiredTick;
	private int payout;
	private int cost;
	private SchoolScript mySchool;
	
	// Use this for initialization
	void Start () 
	{
		mySchool = GameObject.Find("School").GetComponent<SchoolScript>();
		econ = GameObject.Find ("Main Camera").GetComponent<EconomyScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		updateVals ();
		//Debug.Log(payout);
		//Debug.Log(desiredTick);
		//Debug.Log(econ.GetCurrentTick());
		Debug.Log ("time to complete activity" + timeToCompleteActivity);
		if (isActive) 
		{
			int currTick = econ.GetCurrentTick();
			
			if (currTick == desiredTick)
			{
				//Debug.Log("desired tick reached");
				//Debug.Log(currTick);
				mySchool.mealsStored += payout; 
				isActive = false;
				StaticValuesScript.isDonationActive = false;
			}
		}
	}
	
	public void activateFundraising()
	{
		if (ValuesScript.donations >= cost)
		{
			ValuesScript.donations -= cost;
			CalculateDesiredTick ();
			isActive = true;
			StaticValuesScript.isDonationActive = true;
		}
	}
	
	private void CalculateDesiredTick()
	{
		Debug.Log ("desired tick before" + desiredTick);
		Debug.Log ("current tick before calc" + econ.GetCurrentTick());
		desiredTick = econ.GetCurrentTick() + timeToCompleteActivity;
		Debug.Log ("desired tick after" + desiredTick);
	}
	
	private void updateVals()
	{
		Debug.Log ("the current donation from the activity script" + StaticValuesScript.currentFundraising);
		if (StaticValuesScript.currentFundraising == null)
		{
			Debug.Log("the fundraising is null");
		}
		if (StaticValuesScript.currentFundraising == "SmallFood")
		{
			timeToCompleteActivity = StaticValuesScript.smallFoodTime;
			payout = StaticValuesScript.smallFoodValue;
			cost = StaticValuesScript.smallFoodCost;
		}

		if (StaticValuesScript.currentFundraising == "MediumFood")
		{
			timeToCompleteActivity = StaticValuesScript.medFoodTime;
			payout = StaticValuesScript.medFoodValue;
			cost = StaticValuesScript.medFoodCost;
		}

		if (StaticValuesScript.currentFundraising == "LargeFood")
		{
			timeToCompleteActivity = StaticValuesScript.largeFoodTime;
			payout = StaticValuesScript.largeFoodValue;
			cost = StaticValuesScript.largeFoodCost;
		}

		if (StaticValuesScript.currentFundraising == "EducationSupplies")
		{
			timeToCompleteActivity = StaticValuesScript.educationSuppliesTime;
			payout = StaticValuesScript.educationSuppliesValue;
			cost = StaticValuesScript.educationSuppliesCost;
		}

	}
}
