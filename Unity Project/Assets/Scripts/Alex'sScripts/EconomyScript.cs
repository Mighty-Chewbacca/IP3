﻿using UnityEngine;
using System.Collections;

public class EconomyScript : MonoBehaviour 
{
	//this script is going to be the underlying economy
	//we are going to have time, population, population in education, hunger level of school, thirst level of school

	//time variable
	private int currentMinutes, currentDays, currentHours, currentTicks;
	public float normalDelayTime, fastDelayTime, slowDelayTime, currentDelayTime;
	private float delayTime;

	//bool isIncreasing = false;

	// Use this for initialization
	void Start () 
	{
		currentDelayTime = normalDelayTime;
		delayTime = currentDelayTime;
		currentMinutes = 30;
		currentHours = 8;
		currentDays = 1;
		currentTicks = 0;
		//InvokeRepeating ("DecreaseHunger", 1, ValuesScript.decreaseTime);
		//InvokeRepeating ("DecreaseThirst", 1, ValuesScript.decreaseTime);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (delayTime > 0)
		{
			delayTime -= Time.deltaTime;
			//Debug.Log(delayTime);
		}
		else
		{
			currentMinutes += 15;

			if (currentMinutes >= 60)
			{
				currentHours += 1;
				currentMinutes = 0;
			}

			if (currentHours >= 24)
			{
				currentDays += 1;
				currentHours = 0;
			}

			delayTime = currentDelayTime;
			currentTicks += 1;
			//Debug.Log(currentTicks);
			// to tell how many hours have ticked simply get current ticks then stop it when x amount of ticks have passed!
			//allow for multiple time speeds. - key part of complexity to economy
			//for a week to pass it is 672 ticks - check for a new kid every week
			//for a day to pas it is 96 ticks - check meals every day
			//for an hour to pass it is 4 ticks - check the time left on donations and fundraising
		}

		//http://docs.unity3d.com/ScriptReference/MonoBehaviour.CancelInvoke.html

//		if (ValuesScript.hunger > 50 && ValuesScript.thirst > 50 && isIncreasing == false) 
//		{
//			InvokeRepeating("IncreaseEducation", 0, ValuesScript.increaseTime);
//			isIncreasing = true;
//			BroadcastMessage("setEducationIncreasing", isIncreasing);
//		}
//		else if ((ValuesScript.hunger <= 50 || ValuesScript.thirst <= 50) && isIncreasing == true)
//		{
//			CancelInvoke("IncreaseEducation");
//			isIncreasing = false;
//			BroadcastMessage("setEducationIncreasing", isIncreasing);
//		}
	}

	void DecreaseHunger()
	{
//		Debug.Log ("decreasing hunger");
//		ValuesScript.hunger -= ValuesScript.decreaseRateHunger;
	}

	void DecreaseThirst()
	{
//		Debug.Log ("decreasing thirst");
//		ValuesScript.thirst -= ValuesScript.decreaseRateThirst;
	}

	void IncreaseEducation()
	{
//		Debug.Log ("increasing education");
//		ValuesScript.education += ValuesScript.IncreaseRateEducation;
	}

	public void setFastTime()
	{
		currentDelayTime = fastDelayTime;
		delayTime = currentDelayTime;
		StaticValuesScript.currentTimeSpeed = "Fast";
	}

	public void setSlowTime()
	{
		currentDelayTime = slowDelayTime;
		delayTime = currentDelayTime;
		StaticValuesScript.currentTimeSpeed = "Slow";
	}

	public void setNormalTime()
	{
		currentDelayTime = normalDelayTime;
		delayTime = currentDelayTime;
		StaticValuesScript.currentTimeSpeed = "Normal";
	}

	#region get minutes hours and days
	public int GetCurrentMinutes()
	{
		return currentMinutes;
	}

	public int GetCurrentHours()
	{
		return currentHours;
	}

	public int GetCurrentDays()
	{
		return currentDays;
	}

	public int GetCurrentTick()
	{
		return currentTicks;
	}
	#endregion
}
