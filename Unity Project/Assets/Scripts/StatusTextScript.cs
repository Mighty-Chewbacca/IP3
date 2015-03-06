using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusTextScript : MonoBehaviour {

	Text thisText;
	
	// Use this for initialization
	void Start () 
	{
		//we want to grab the ui stuff for right now, instead of focusing on the world at the minute
		thisText = GetComponent<Text>();
		
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
	
	}
}
