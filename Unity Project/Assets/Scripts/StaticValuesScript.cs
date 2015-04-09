using UnityEngine;
using System.Collections;

public class StaticValuesScript : MonoBehaviour 
{
	//fundraising stuff
	public static int sponsoredRunCost, sponsoredRunValue, sponsoredRunTime;
	public static int sponsoredSilenceCost, sponsoredSilenceValue, sponsoredSilenceTime;
	public static int fashionShowCost, fashionShowValue, fashionShowTime;
	public static int nonUniformDayCost, nonUniformDayValue, nonUniformDayTime;
	public static int crazyHairDayCost, crazyHairDayValue, crazyHairDayTime;
	public static int supermarketBagPackCost, supermarketBagPackValue, supermarketBagPackTime;
	public static int rafflesCost, rafflesValue, rafflesTime;
	public static int radioSpotCost, radioSpotValue, radioSpotTime;
	public static int tvSpotCost, tvSpotValue, tvSpotTime;
	public static int onlineAdsCost, onlineAdsValue, onlineAdsTime;
	public static int backpackProjectCost, backpackProjectValue, backpackProjectTime;

	//donation stuff
	public static int smallFoodCost, smallFoodValue, smallFoodTime;
	public static int medFoodCost, medFoodValue, medFoodTime;
	public static int largeFoodCost, largeFoodValue, largeFoodTime;

	public static int educationSuppliesCost, educationSuppliesValue, educationSuppliesTime;

	public static string currentFundraising;
	public static bool isFundraisingActive;

	public static string currentDonation;
	public static bool isDonationActive;

	public static string currentTimeSpeed;

	// Use this for initialization
	void Start () 
	{
		//initiate value of all statics - these are mainly the values that the donation events will be worth

		//fundraising stuff
		sponsoredSilenceCost = 50; sponsoredSilenceValue = 150; sponsoredSilenceTime = 8;
		sponsoredRunCost = 100; sponsoredRunValue = 200; sponsoredRunTime = 8;
		fashionShowCost = 150; fashionShowValue = 300; fashionShowTime = 8;
		nonUniformDayCost = 200; nonUniformDayValue = 350; nonUniformDayTime = 8;
		crazyHairDayCost = 250; crazyHairDayValue = 450; crazyHairDayTime = 8;
		supermarketBagPackCost = 300; supermarketBagPackValue = 500; supermarketBagPackTime = 8;
		rafflesCost = 350; rafflesValue = 600; rafflesTime = 8;
		radioSpotCost = 400; radioSpotValue = 650; radioSpotTime = 8;
		tvSpotCost = 450; tvSpotValue = 700; tvSpotTime = 8;
		onlineAdsCost = 500; onlineAdsValue = 750; onlineAdsTime = 8;
		backpackProjectCost = 550; backpackProjectValue = 800; backpackProjectTime = 8;

		//donation stuff
		smallFoodCost = 150; smallFoodValue = 1; smallFoodTime = 10;
		medFoodCost = 250; medFoodValue = 2; medFoodTime = 10;
		largeFoodCost = 400; largeFoodValue = 3; largeFoodTime = 10;

		educationSuppliesCost = 250; educationSuppliesValue = 5; educationSuppliesTime = 10;



		currentFundraising = "temp";
		currentDonation = "temp";
		currentTimeSpeed = "Normal";
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("the current fundraising from static val script" + currentFundraising);
	}
}
