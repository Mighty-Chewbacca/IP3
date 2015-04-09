using UnityEngine;
using System.Collections;

public class AddDonations : MonoBehaviour
{
	// Update is called once per frame
	public void DonationsAdd () 
	{
		ValuesScript.donations = ValuesScript.donations + 10;
	}
}
