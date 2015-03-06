using UnityEngine;
using System.Collections;

public class EconomyScript : MonoBehaviour {

	bool isIncreasing = false;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("DecreaseHunger", 1, ValuesScript.decreaseTime);
		InvokeRepeating ("DecreaseThirst", 1, ValuesScript.decreaseTime);
	
	}
	
	// Update is called once per frame
	void Update () {
		//http://docs.unity3d.com/ScriptReference/MonoBehaviour.CancelInvoke.html

		if (ValuesScript.hunger > 50 && ValuesScript.thirst > 50 && isIncreasing == false) 
		{
			InvokeRepeating("IncreaseEducation", 0, ValuesScript.increaseTime);
			isIncreasing = true;
			BroadcastMessage("setEducationIncreasing", isIncreasing);
		}
		else if ((ValuesScript.hunger <= 50 || ValuesScript.thirst <= 50) && isIncreasing == true)
		{
			CancelInvoke("IncreaseEducation");
			isIncreasing = false;
			BroadcastMessage("setEducationIncreasing", isIncreasing);
		}
	}

	void DecreaseHunger()
	{
		Debug.Log ("decreasing hunger");
		ValuesScript.hunger -= ValuesScript.decreaseRateHunger;
	}

	void DecreaseThirst()
	{
		Debug.Log ("decreasing thirst");
		ValuesScript.thirst -= ValuesScript.decreaseRateThirst;
	}

	void IncreaseEducation()
	{
		Debug.Log ("increasing education");
		ValuesScript.education += ValuesScript.IncreaseRateEducation;
	}
}
