using UnityEngine;
using System.Collections;

public class CurrentFundraisingActivityScript : MonoBehaviour 
{
	//there will only be one of these available at once
	//it will be the current fundraising activity and will control all sorts to do with that!
	private EconomyScript econ;

	private bool isActive = false;

	private int timeToCompleteActivity;
	private int desiredTick;
	private int payout;
	private int cost;

	// Use this for initialization
	void Start () 
	{
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
				ValuesScript.donations += payout; 
				isActive = false;
				StaticValuesScript.isFundraisingActive = false;
			}
		}
	}

	public void activateFundraising()
	{
		if (ValuesScript.donations >= cost && isActive == false)
		{
			ValuesScript.donations -= cost;
			CalculateDesiredTick ();
			isActive = true;
			StaticValuesScript.isFundraisingActive = true;
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
		Debug.Log ("the current fundraising from the activity script" + StaticValuesScript.currentFundraising);
		if (StaticValuesScript.currentFundraising == null)
		{
			Debug.Log("the fundraising is null");
		}

		if (StaticValuesScript.currentFundraising == "SponsoredSilence")
		{
			timeToCompleteActivity = StaticValuesScript.sponsoredSilenceTime;
			payout = StaticValuesScript.sponsoredSilenceValue;
			cost = StaticValuesScript.sponsoredSilenceCost;
		}
		if (StaticValuesScript.currentFundraising == "SponsoredRun")
		{
			timeToCompleteActivity = StaticValuesScript.sponsoredRunTime;
			payout = StaticValuesScript.sponsoredRunValue;
			cost = StaticValuesScript.sponsoredRunCost;
		}
		if (StaticValuesScript.currentFundraising == "FashionShow")
		{
			timeToCompleteActivity = StaticValuesScript.fashionShowTime;
			payout = StaticValuesScript.fashionShowValue;
			cost = StaticValuesScript.fashionShowCost;
		}
		if (StaticValuesScript.currentFundraising == "SupermarketBagPack")
		{
			timeToCompleteActivity = StaticValuesScript.supermarketBagPackTime;
			payout = StaticValuesScript.supermarketBagPackValue;
			cost = StaticValuesScript.supermarketBagPackCost;
		}
		if (StaticValuesScript.currentFundraising == "Raffles")
		{
			timeToCompleteActivity = StaticValuesScript.rafflesTime;
			payout = StaticValuesScript.rafflesValue;
			cost = StaticValuesScript.rafflesCost;
		}
		if (StaticValuesScript.currentFundraising == "NonUniformDay")
		{
			timeToCompleteActivity = StaticValuesScript.nonUniformDayTime;
			payout = StaticValuesScript.nonUniformDayValue;
			cost = StaticValuesScript.nonUniformDayCost;
		}
		if (StaticValuesScript.currentFundraising == "BackpackChallenge")
		{
			timeToCompleteActivity = StaticValuesScript.backpackProjectTime;
			payout = StaticValuesScript.backpackProjectValue;
			cost = StaticValuesScript.backpackProjectCost;
		}
		if (StaticValuesScript.currentFundraising == "TVSpot")
		{
			timeToCompleteActivity = StaticValuesScript.tvSpotTime;
			payout = StaticValuesScript.tvSpotValue;
			cost = StaticValuesScript.tvSpotCost;
		}
		if (StaticValuesScript.currentFundraising == "RadioSpot")
		{
			timeToCompleteActivity = StaticValuesScript.radioSpotTime;
			payout = StaticValuesScript.radioSpotValue;
			cost = StaticValuesScript.radioSpotCost;
		}
		if (StaticValuesScript.currentFundraising == "OnlineAds")
		{
			timeToCompleteActivity = StaticValuesScript.onlineAdsTime;
			payout = StaticValuesScript.onlineAdsValue;
			cost = StaticValuesScript.onlineAdsCost;
		}
		if (StaticValuesScript.currentFundraising == "CrazyHair")
		{
			timeToCompleteActivity = StaticValuesScript.crazyHairDayTime;
			payout = StaticValuesScript.crazyHairDayValue;
			cost = StaticValuesScript.crazyHairDayCost;
		}
	}
}
