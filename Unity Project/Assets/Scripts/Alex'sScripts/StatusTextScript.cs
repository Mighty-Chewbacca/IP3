using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusTextScript : MonoBehaviour {

	Text thisText;
	EconomyScript mainEconomy;
	
	// Use this for initialization
	void Start () 
	{
		//we want to grab the ui stuff for right now, instead of focusing on the world at the minute
		thisText = GetComponent<Text>();
		mainEconomy = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<EconomyScript>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (this.name == "StatusText") 
		{
			this.thisText.text = "Running";
		}

		if (this.name == "EducationStatusText" && ValuesScript.educationIncreasing == true) 
		{
			this.thisText.text = "Education is increasing";
		}

		if (this.name == "EducationStatusText" && ValuesScript.educationIncreasing == false) 
		{
			this.thisText.text = "Education is not increasing";
		}

		if (this.name == "currentStatusText" && StaticValuesScript.isFundraisingActive) 
		{
			this.thisText.text = "Currently Fundraising:" + StaticValuesScript.currentFundraising;
		}
		if (this.name == "currentStatusText" && !StaticValuesScript.isFundraisingActive) 
		{
			this.thisText.text = "Not Currently Fundraising:";
		}

		if (this.name == "TimeText") 
		{
			if (mainEconomy.GetCurrentMinutes() == 0)
			{
				if (mainEconomy.GetCurrentHours() < 12)
				{
				this.thisText.text = "Day:" + mainEconomy.GetCurrentDays().ToString() + "         Time:" + mainEconomy.GetCurrentHours().ToString() + ":" + 
					mainEconomy.GetCurrentMinutes().ToString() + "0" + " AM";
				}
				else
				{
					this.thisText.text = "Day:" + mainEconomy.GetCurrentDays().ToString() + "         Time:" + mainEconomy.GetCurrentHours().ToString() + ":" + 
						mainEconomy.GetCurrentMinutes().ToString() + "0" + " PM";
				}
			}
			else
			{
				if (mainEconomy.GetCurrentHours() < 12)
				{
				this.thisText.text = "Day:" + mainEconomy.GetCurrentDays().ToString() + "         Time:" + mainEconomy.GetCurrentHours().ToString() + ":" +
					mainEconomy.GetCurrentMinutes().ToString() + " AM";
				}
				else
				{
					this.thisText.text = "Day:" + mainEconomy.GetCurrentDays().ToString() + "         Time:" + mainEconomy.GetCurrentHours().ToString() + ":" +
						mainEconomy.GetCurrentMinutes().ToString() + " PM";
				}
			}
		}
	
	}
}
