using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControlScript : MonoBehaviour {
	
	Text thisText;

	// Use this for initialization
	void Start () 
	{
	//we want to grab the ui stuff for right now, instead of focusing on the world at the minute
		thisText = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.name == "ThirstValue") 
		{
			this.thisText.text = ValuesScript.thirst.ToString();
		}

		if (this.name == "HungerValue") 
		{
			this.thisText.text = ValuesScript.hunger.ToString();
		}

		if (this.name == "EducationLevel") 
		{
			this.thisText.text = ValuesScript.education.ToString();
		}

		if (this.name == "DonationsValue") 
		{
			this.thisText.text = ValuesScript.donations.ToString();
		}
	
	}
}
