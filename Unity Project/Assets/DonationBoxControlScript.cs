using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DonationBoxControlScript : MonoBehaviour {
	//this script will control the text in the donations box, it will change the text dependent on what is clicked
	private string currentDonation;
	private Text nameText, valueText, descText, timeText;
	// Use this for initialization
	void Start () 
	{
		nameText = GameObject.Find ("fundraisingNameText").GetComponent<Text>();
		valueText = GameObject.Find ("fundraisingValueText").GetComponent<Text>();
		descText = GameObject.Find ("fundraisingDescriptionText").GetComponent<Text>();
		timeText = GameObject.Find ("fundraisingTimeText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ( "static current fundraising before change" + StaticValuesScript.currentFundraising);
		StaticValuesScript.currentFundraising = currentDonation;
		Debug.Log (currentDonation);
		Debug.Log ("static current fundraising after change" + StaticValuesScript.currentFundraising);
		if (currentDonation == "Fetes")
		{
			nameText.text = "Fetes";
			valueText.text = "Costs:" + StaticValuesScript.fetesCost.ToString() + " returns:" + StaticValuesScript.fetesValue.ToString();
			descText.text = "Fetes desc";
			timeText.text = "It will take " + StaticValuesScript.fetesTime.ToString() + " Hours";
		}

		if (currentDonation == "SponsoredChallenge")
		{
			nameText.text = "SponsoredChallenge";
			valueText.text = "Costs:" + StaticValuesScript.sponsoredChallengeCost.ToString() + " returns:" + StaticValuesScript.sponsoredChallengeValue.ToString();
			descText.text = "SponsoredChallenge desc";
			timeText.text = "It will take " + StaticValuesScript.sponsoredChallengeTime.ToString() + " Hours";
		}

		if (currentDonation == "SponsoredFun")
		{
			nameText.text = "SponsoredFun";
			valueText.text = "Costs:" + StaticValuesScript.sponsoredFunCost.ToString() + " returns:" + StaticValuesScript.sponsoredFunValue.ToString();
			descText.text = "SponsoredFun desc";
			timeText.text = "It will take " + StaticValuesScript.sponsoredFunTime.ToString() + " Hours";
		}

		if (currentDonation == "QuizNight")
		{
			nameText.text = "QuizNight";
			valueText.text = "Costs:" + StaticValuesScript.quizNightCost.ToString() + " returns:" + StaticValuesScript.quizNightValue.ToString();
			descText.text = "QuizNight desc";
			timeText.text = "It will take " + StaticValuesScript.quizNightTime.ToString() + " Hours";
		}

		if (currentDonation == "FashionShow")
		{
			nameText.text = "FashionShow";
			valueText.text = "Costs:" + StaticValuesScript.fashionShowCost.ToString() + " returns:" + StaticValuesScript.fashionShowValue.ToString();
			descText.text = "FashionShow desc";
			timeText.text = "It will take " + StaticValuesScript.fashionShowTime.ToString() + " Hours";
		}

		if (currentDonation == "SupermarketBagPack")
		{
			nameText.text = "SupermarketBagPack";
			valueText.text = "Costs:" + StaticValuesScript.supermarketBagPackCost.ToString() + " returns:" + StaticValuesScript.supermarketBagPackValue.ToString();
			descText.text = "SupermarketBagPack desc";
			timeText.text = "It will take " + StaticValuesScript.supermarketBagPackTime.ToString() + " Hours";
		}

		if (currentDonation == "Raffles")
		{
			nameText.text = "Raffles";
			valueText.text = "Costs:" + StaticValuesScript.rafflesCost.ToString() + " returns:" + StaticValuesScript.rafflesValue.ToString();
			descText.text = "Raffles desc";
			timeText.text = "It will take " + StaticValuesScript.rafflesTime.ToString() + " Hours";
		}

		if (currentDonation == "NonUniformDay")
		{
			nameText.text = "NonUniformDay";
			valueText.text = "Costs:" + StaticValuesScript.nonUniformDayCost.ToString() + " returns:" + StaticValuesScript.nonUniformDayValue.ToString();
			descText.text = "NonUniformDay desc";
			timeText.text = "It will take " + StaticValuesScript.nonUniformDayTime.ToString() + " Hours";
		}

		if (currentDonation == "BackpackChallenge")
		{
			nameText.text = "BackpackChallenge";
			valueText.text = "Costs:" + StaticValuesScript.backpackProjectCost.ToString() + " returns:" + StaticValuesScript.backpackProjectValue.ToString();
			descText.text = "BackpackChallenge desc";
			timeText.text = "It will take " + StaticValuesScript.backpackProjectTime.ToString() + " Hours";
		}

		if (currentDonation == "TVSpot")
		{
			nameText.text = "TVSpot";
			valueText.text = "Costs:" + StaticValuesScript.tvSpotCost.ToString() + " returns:" + StaticValuesScript.tvSpotValue.ToString();
			descText.text = "TVSpot desc";
			timeText.text = "It will take " + StaticValuesScript.tvSpotTime.ToString() + " Hours";
		}

		if (currentDonation == "RadioSpot")
		{
			nameText.text = "RadioSpot";
			valueText.text = "Costs:" + StaticValuesScript.radioSpotCost.ToString() + " returns:" + StaticValuesScript.radioSpotValue.ToString();
			descText.text = "RadioSpot desc";
			timeText.text = "It will take " + StaticValuesScript.radioSpotTime.ToString() + " Hours";
		}

		if (currentDonation == "OnlineAds")
		{
			nameText.text = "OnlineAds";
			valueText.text = "Costs:" + StaticValuesScript.onlineAdsCost.ToString() + " returns:" + StaticValuesScript.onlineAdsValue.ToString();
			descText.text = "OnlineAds desc";
			timeText.text = "It will take " + StaticValuesScript.onlineAdsTime.ToString() + " Hours";
		}

		if (currentDonation == "NewsPaperAds")
		{
			nameText.text = "NewsPaperAds";
			valueText.text = "Costs:" + StaticValuesScript.newspaperAdsCost.ToString() + " returns:" + StaticValuesScript.newspaperAdsValue.ToString();
			descText.text = "NewsPaperAds desc";
			timeText.text = "It will take " + StaticValuesScript.newspaperAdsTime.ToString() + " Hours";
		}
	}

	public void FetesDonation()
	{
		currentDonation = "Fetes";
	}
	public void SponsoredChallengeDonation()
	{
		currentDonation = "SponsoredChallenge";
	}
	public void SponsoredFunDonation()
	{
		currentDonation = "SponsoredFun";
	}
	public void QuizNightDonation()
	{
		currentDonation = "QuizNight";
	}
	public void FashionShowDonation()
	{
		currentDonation = "FashionShow";
	}
	public void SupermarketBagPackDonation()
	{
		currentDonation = "SupermarketBagPack";
	}
	public void RafflesDonation()
	{
		currentDonation = "Raffles";
	}
	public void NonUniformDayDonation()
	{
		currentDonation = "NonUniformDay";
	}
	public void BackPackChallengeDonation()
	{
		currentDonation = "BackpackChallenge";
	}
	public void TVSpotDonation()
	{
		currentDonation = "TVSpot";
	}
	public void RadioSpotDonation()
	{
		currentDonation = "RadioSpot";
	}
	public void OnlineAdsDonation()
	{
		currentDonation = "OnlineAds";
	}
	public void NewspaperAdsDonation()
	{
		currentDonation = "NewsPaperAds";
	}
}
