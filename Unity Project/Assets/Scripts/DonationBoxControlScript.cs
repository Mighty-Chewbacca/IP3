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
		Debug.Log ( "static current donation before change" + StaticValuesScript.currentDonation);
		Debug.Log (currentDonation);
		Debug.Log ("static current donation after change" + StaticValuesScript.currentDonation);

		if (currentDonation == "SmallFood")
		{
			StaticValuesScript.currentDonation = currentDonation;
			nameText.text = "Small Food Package";
			valueText.text = "Costs:" + StaticValuesScript.smallFoodCost.ToString() + " returns:" + StaticValuesScript.smallFoodValue.ToString() + " Meals";
			descText.text = "food desc";
			timeText.text = "It will take " + StaticValuesScript.smallFoodTime.ToString() + " Hours";
		}

		if (currentDonation == "MediumFood")
		{
			StaticValuesScript.currentDonation = currentDonation;
			nameText.text = "Medium Food Package";
			valueText.text = "Costs:" + StaticValuesScript.medFoodCost.ToString() + " returns:" + StaticValuesScript.medFoodValue.ToString() + " Meals";
			descText.text = "food desc";
			timeText.text = "It will take " + StaticValuesScript.medFoodTime.ToString() + " Hours";
		}

		if (currentDonation == "LargeFood")
		{
			StaticValuesScript.currentDonation = currentDonation;
			nameText.text = "Large Food Package";
			valueText.text = "Costs:" + StaticValuesScript.largeFoodCost.ToString() + " returns:" + StaticValuesScript.largeFoodValue.ToString() + " Meals";
			descText.text = "food desc";
			timeText.text = "It will take " + StaticValuesScript.largeFoodTime.ToString() + " Hours";
		}

		if (currentDonation == "EducationSupplies")
		{
			StaticValuesScript.currentDonation = currentDonation;
			nameText.text = "Education Supplies Package";
			valueText.text = "Costs:" + StaticValuesScript.educationSuppliesCost.ToString() + " returns:" + StaticValuesScript.educationSuppliesValue.ToString() + " Supplies";
			descText.text = "These are used to upgrade your buildings!";
			timeText.text = "It will take " + StaticValuesScript.educationSuppliesTime.ToString() + " Hours";
		}

	}

	public void SmallFood()
	{
		currentDonation = "SmallFood";
	}

	public void MedFood()
	{
		currentDonation = "MediumFood";
	}

	public void LargeFood()
	{
		currentDonation = "LargeFood";
	}

	public void EducationSupplies()
	{
		currentDonation = "EducationSupplies";
	}
}
