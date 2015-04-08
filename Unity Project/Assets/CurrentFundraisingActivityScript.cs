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
		ValuesScript.donations -= 1000;
		CalculateDesiredTick ();
		isActive = true;
		StaticValuesScript.isFundraisingActive = true;
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
		if (StaticValuesScript.currentFundraising == "Fetes")
		{
			Debug.Log("entered fetes timetocomplete setter");
			timeToCompleteActivity = StaticValuesScript.fetesTime;
			payout = StaticValuesScript.fetesValue;
		}
		if (StaticValuesScript.currentFundraising == "SponsoredChallenge")
		{
			timeToCompleteActivity = StaticValuesScript.sponsoredChallengeTime;
			payout = StaticValuesScript.sponsoredChallengeValue;
		}
		if (StaticValuesScript.currentFundraising == "SponsoredFun")
		{
			timeToCompleteActivity = StaticValuesScript.sponsoredFunTime;
			payout = StaticValuesScript.sponsoredFunValue;
		}
		if (StaticValuesScript.currentFundraising == "QuizNight")
		{
			timeToCompleteActivity = StaticValuesScript.quizNightTime;
			payout = StaticValuesScript.quizNightValue;
		}
		if (StaticValuesScript.currentFundraising == "FashionShow")
		{
			timeToCompleteActivity = StaticValuesScript.fashionShowTime;
			payout = StaticValuesScript.fashionShowValue;
		}
		if (StaticValuesScript.currentFundraising == "SupermarketBagPack")
		{
			timeToCompleteActivity = StaticValuesScript.supermarketBagPackTime;
			payout = StaticValuesScript.supermarketBagPackValue;
		}
		if (StaticValuesScript.currentFundraising == "Raffles")
		{
			timeToCompleteActivity = StaticValuesScript.rafflesTime;
			payout = StaticValuesScript.rafflesValue;
		}
		if (StaticValuesScript.currentFundraising == "NonUniformDay")
		{
			timeToCompleteActivity = StaticValuesScript.nonUniformDayTime;
			payout = StaticValuesScript.nonUniformDayValue;
		}
		if (StaticValuesScript.currentFundraising == "BackpackChallenge")
		{
			timeToCompleteActivity = StaticValuesScript.backpackProjectTime;
			payout = StaticValuesScript.backpackProjectValue;
		}
		if (StaticValuesScript.currentFundraising == "TVSpot")
		{
			timeToCompleteActivity = StaticValuesScript.tvSpotTime;
			payout = StaticValuesScript.tvSpotValue;
		}
		if (StaticValuesScript.currentFundraising == "RadioSpot")
		{
			timeToCompleteActivity = StaticValuesScript.radioSpotTime;
			payout = StaticValuesScript.radioSpotValue;
		}
		if (StaticValuesScript.currentFundraising == "OnlineAds")
		{
			timeToCompleteActivity = StaticValuesScript.onlineAdsTime;
			payout = StaticValuesScript.onlineAdsValue;
		}
		if (StaticValuesScript.currentFundraising == "NewsPaperAds")
		{
			timeToCompleteActivity = StaticValuesScript.newspaperAdsValue;
			payout = StaticValuesScript.newspaperAdsValue;
		}


	}
}
