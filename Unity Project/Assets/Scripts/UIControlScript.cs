using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControlScript : MonoBehaviour {
	
	Text thisText;

	ModelChangerScript church, well, school;

	// Use this for initialization
	void Start () 
	{
	//we want to grab the ui stuff for right now, instead of focusing on the world at the minute
		thisText = GetComponent<Text>();

		church = GameObject.Find ("Church").GetComponent<ModelChangerScript> ();

		well = GameObject.Find ("Wells").GetComponent<ModelChangerScript> ();

		school = GameObject.Find ("School").GetComponent<ModelChangerScript> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (this.name == "DonationsValue") 
		{
			this.thisText.text = ValuesScript.donations.ToString();
		}

		if (this.name == "timeControlsText") 
		{
			this.thisText.text = "Current Speed: " + StaticValuesScript.currentTimeSpeed;
		}

		if (this.name == "SchoolLevel") 
		{
			this.thisText.text = "Current Level: " + school.getHouseLevel().ToString();
		}

		if (this.name == "wellLevel") 
		{
			this.thisText.text = "Current Level: " + well.getHouseLevel().ToString();
		}

		if (this.name == "churchLevel") 
		{
			this.thisText.text = "Current Level: " + church.getHouseLevel().ToString();
		}
	}
}
