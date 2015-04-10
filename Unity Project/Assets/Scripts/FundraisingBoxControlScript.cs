using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FundraisingBoxControlScript : MonoBehaviour {
	//this script will control the text in the donations box, it will change the text dependent on what is clicked
	private string currentFundraising;
	private Text nameText, valueText, descText, timeText;
	// Use this for initialization
	void Start () 
	{
		nameText = GameObject.Find ("DonationNameText").GetComponent<Text>();
		valueText = GameObject.Find ("DonationValueText").GetComponent<Text>();
		descText = GameObject.Find ("DonationDescriptionText").GetComponent<Text>();
		timeText = GameObject.Find ("DonationTimeText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ( "static current fundraising before change" + StaticValuesScript.currentFundraising);
		Debug.Log (currentFundraising);
		Debug.Log ("static current fundraising after change" + StaticValuesScript.currentFundraising);
		if (currentFundraising == "CrazyHair")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Crazy Hair Day";
			valueText.text = "Costs:" + StaticValuesScript.crazyHairDayCost.ToString() + " returns:" + StaticValuesScript.crazyHairDayValue.ToString();
			descText.text = "You take part in a crazy hair day at your school to raise money!";
			timeText.text = "It will take " + (StaticValuesScript.crazyHairDayTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "SponsoredSilence")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Sponsored Silence";
			valueText.text = "Costs:" + StaticValuesScript.sponsoredSilenceCost.ToString() + " returns:" + StaticValuesScript.sponsoredSilenceValue.ToString();
			descText.text = "You collect sponsors from friends and family to complete a sponsored silence at home or school!";
			timeText.text = "It will take " + (StaticValuesScript.sponsoredSilenceTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "SponsoredRun")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Sponsored Run";
			valueText.text = "Costs:" + StaticValuesScript.sponsoredRunCost.ToString() + " returns:" + StaticValuesScript.sponsoredRunValue.ToString();
			descText.text = "You collect sponsors from friends and family to complete a sponsored run at home or school!";
			timeText.text = "It will take " + (StaticValuesScript.sponsoredRunTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "FashionShow")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Fashion Show";
			valueText.text = "Costs:" + StaticValuesScript.fashionShowCost.ToString() + " returns:" + StaticValuesScript.fashionShowValue.ToString();
			descText.text = "You take part in a fashion show with all proceeds going to marys meals!";
			timeText.text = "It will take " + (StaticValuesScript.fashionShowTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "SupermarketBagPack")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "SupermarketBagPack";
			valueText.text = "Costs:" + StaticValuesScript.supermarketBagPackCost.ToString() + " returns:" + StaticValuesScript.supermarketBagPackValue.ToString();
			descText.text = "SupermarketBagPack desc";
			timeText.text = "It will take " + (StaticValuesScript.supermarketBagPackTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "Raffles")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Raffle";
			valueText.text = "Costs:" + StaticValuesScript.rafflesCost.ToString() + " returns:" + StaticValuesScript.rafflesValue.ToString();
			descText.text = "Your school  holds a raffle to raise money for marys meals!";
			timeText.text = "It will take " + (StaticValuesScript.rafflesTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "NonUniformDay")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Non-Uniform Day";
			valueText.text = "Costs:" + StaticValuesScript.nonUniformDayCost.ToString() + " returns:" + StaticValuesScript.nonUniformDayValue.ToString();
			descText.text = "You take part in a non-uniform day at school to raise money for marys meals!";
			timeText.text = "It will take " + (StaticValuesScript.nonUniformDayTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "BackpackChallenge")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Backpack Challenge";
			valueText.text = "Costs:" + StaticValuesScript.backpackProjectCost.ToString() + " returns:" + StaticValuesScript.backpackProjectValue.ToString();
			descText.text = "Marys meals runs another successful backpack project!";
			timeText.text = "It will take " + (StaticValuesScript.backpackProjectTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "TVSpot")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "TV Spot";
			valueText.text = "Costs:" + StaticValuesScript.tvSpotCost.ToString() + " returns:" + StaticValuesScript.tvSpotValue.ToString();
			descText.text = "Marys meals buys a TV ad to tell people about their charity!";
			timeText.text = "It will take " + (StaticValuesScript.tvSpotTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "RadioSpot")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Radio Spot";
			valueText.text = "Costs:" + StaticValuesScript.radioSpotCost.ToString() + " returns:" + StaticValuesScript.radioSpotValue.ToString();
			descText.text = "Marys meals buys a radio ad to tell people about their charity!";
			timeText.text = "It will take " + (StaticValuesScript.radioSpotTime / 4).ToString() + " Hours";
		}
		
		if (currentFundraising == "OnlineAds")
		{
			StaticValuesScript.currentFundraising = currentFundraising;
			nameText.text = "Online Ads";
			valueText.text = "Costs:" + StaticValuesScript.onlineAdsCost.ToString() + " returns:" + StaticValuesScript.onlineAdsValue.ToString();
			descText.text = "Marys meals buys an online ad to tell people about their charity!";
			timeText.text = "It will take " + (StaticValuesScript.onlineAdsTime / 4).ToString() + " Hours";
		}
	}
	
	public void CrazyHairDonation()
	{
		currentFundraising = "CrazyHair";
	}
	public void SponsoredSilenceDonation()
	{
		currentFundraising = "SponsoredSilence";
	}
	public void SponsoredRunDonation()
	{
		currentFundraising = "SponsoredRun";
	}
	public void FashionShowDonation()
	{
		currentFundraising = "FashionShow";
	}
	public void SupermarketBagPackDonation()
	{
		currentFundraising = "SupermarketBagPack";
	}
	public void RafflesDonation()
	{
		currentFundraising = "Raffles";
	}
	public void NonUniformDayDonation()
	{
		currentFundraising = "NonUniformDay";
	}
	public void BackPackChallengeDonation()
	{
		currentFundraising = "BackpackChallenge";
	}
	public void TVSpotDonation()
	{
		currentFundraising = "TVSpot";
	}
	public void RadioSpotDonation()
	{
		currentFundraising = "RadioSpot";
	}
	public void OnlineAdsDonation()
	{
		currentFundraising = "OnlineAds";
	}
}
