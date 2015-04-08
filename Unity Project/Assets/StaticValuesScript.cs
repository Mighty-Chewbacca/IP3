using UnityEngine;
using System.Collections;

public class StaticValuesScript : MonoBehaviour 
{
	public static int fetesCost, fetesValue, fetesTime;
	public static int sponsoredChallengeCost, sponsoredChallengeValue, sponsoredChallengeTime;
	public static int sponsoredFunCost, sponsoredFunValue, sponsoredFunTime;
	public static int quizNightCost, quizNightValue, quizNightTime;
	public static int fashionShowCost, fashionShowValue, fashionShowTime;
	public static int supermarketBagPackCost, supermarketBagPackValue, supermarketBagPackTime;
	public static int rafflesCost, rafflesValue, rafflesTime;
	public static int nonUniformDayCost, nonUniformDayValue, nonUniformDayTime;
	public static int backpackProjectCost, backpackProjectValue, backpackProjectTime;
	public static int tvSpotCost, tvSpotValue, tvSpotTime;
	public static int radioSpotCost, radioSpotValue, radioSpotTime;
	public static int onlineAdsCost, onlineAdsValue, onlineAdsTime;
	public static int newspaperAdsCost, newspaperAdsValue, newspaperAdsTime;

	public static string currentFundraising;
	public static bool isFundraisingActive;

	public static string currentTimeSpeed;

	// Use this for initialization
	void Start () 
	{
		//initiate value of all statics - these are mainly the values that the donation events will be worth
		fetesCost = 1; fetesValue = 10; fetesTime = 5;
		sponsoredChallengeCost = 2; sponsoredChallengeValue = 20; sponsoredChallengeTime = 2;
		sponsoredFunCost = 3; sponsoredFunValue = 30; sponsoredFunTime = 3;
		quizNightCost = 4; quizNightValue = 40; quizNightTime = 4;
		fashionShowCost = 5; fashionShowValue = 50; fashionShowTime = 5;
		supermarketBagPackCost = 6; supermarketBagPackValue = 60; supermarketBagPackTime = 6;
		rafflesCost = 7; rafflesValue = 70; rafflesTime = 7;
		nonUniformDayCost = 8; nonUniformDayValue = 80; nonUniformDayTime = 8;
		backpackProjectCost = 9; backpackProjectValue = 90; backpackProjectTime = 9;
		tvSpotCost = 10; tvSpotValue = 100; tvSpotTime = 10;
		radioSpotCost = 11; radioSpotValue = 110; radioSpotTime = 11;
		onlineAdsCost = 12; onlineAdsValue = 120; onlineAdsTime = 12;
		newspaperAdsCost = 13; newspaperAdsValue = 130; newspaperAdsTime = 13;

		currentFundraising = "temp";
		currentTimeSpeed = "Normal";
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("the current fundraising from static val script" + currentFundraising);
	}
}
