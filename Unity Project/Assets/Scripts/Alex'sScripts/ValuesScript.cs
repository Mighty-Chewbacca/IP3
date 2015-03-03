using UnityEngine;
using System.Collections;

public class ValuesScript : MonoBehaviour 
{
	//statics so that they can be easily accessed by entire game as they are the crux of economy
	public static int hunger, thirst, education, donations, decreaseRateHunger, decreaseRateThirst, decreaseTime, increaseTime, IncreaseRateEducation;

	//temp stuff so the values are visible in the editor
	public int tempHunger, tempThirst, tempEducation, tempDonations, tempHungerDecrease, tempThirstDecrease, tempDecreaseTime, tempIncreaseTime, tempEducationIncrease;

	//starting values for the stats, made so that designer can change in editor
	public int hungerStartingValue, thirstStartingValue, educationStartingValue, donationsStartingValue, hungerDecreaseStarting, thirstDecreaseStarting, decreaseTimeStarting, increaseTimeStarting,
	educationIncreaseStarting;

	public float timeScale;

	// Use this for initialization
	void Start () 
	{
		hunger = hungerStartingValue;
		thirst = thirstStartingValue;
		education = educationStartingValue;
		donations = donationsStartingValue;

		decreaseRateHunger = hungerDecreaseStarting;
		decreaseRateThirst = thirstDecreaseStarting;
		IncreaseRateEducation = educationIncreaseStarting;

		decreaseTime = decreaseTimeStarting;
		increaseTime = increaseTimeStarting;
	}
	
	// Update is called once per frame
	void Update () 
	{
		tempDonations = donations;
		tempEducation = education;
		tempHunger = hunger;
		tempThirst = thirst;

		tempHungerDecrease = decreaseRateHunger;
		tempThirstDecrease = decreaseRateThirst;
		tempEducationIncrease = IncreaseRateEducation;

		tempDecreaseTime = decreaseTime;
		tempIncreaseTime = increaseTime;

		timeScale = Time.timeScale;

		if (hunger >= 100)
		{
			ValuesScript.hunger = 100;
		}

		if (thirst >= 100)
		{
			ValuesScript.thirst = 100;
		}

		if (hunger <= 0)
		{
			ValuesScript.hunger = 0;
		}
		
		if (thirst <= 0)
		{
			ValuesScript.thirst = 0;
		}

		if (donations <= 0)
		{
			ValuesScript.donations = 0;
		}
	}
}
