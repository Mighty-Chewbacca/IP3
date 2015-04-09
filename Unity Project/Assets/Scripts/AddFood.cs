using UnityEngine;
using System.Collections;

public class AddFood : MonoBehaviour 
{
	public void Food() //the method that will add food and remove donations
	{
		if (ValuesScript.donations > 9 && (ValuesScript.hunger < 100 ||ValuesScript.thirst < 100)) 
		{
			ValuesScript.hunger = ValuesScript.hunger + 10;
			ValuesScript.thirst = ValuesScript.thirst + 10;
			ValuesScript.donations = ValuesScript.donations - 10;
		}
	}
}
