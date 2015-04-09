using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainGameUIScript : MonoBehaviour {

	public Animator fundraisingScrollBox;
	public Animator donationSelectionBox;
	public Animator wellbeingButton;
	public Animator buildingInfoBox;
	public Animator optionsBox;
	public Animator aidScrollBox;

	public void openFundraising()
	{
		if (StaticValuesScript.isFundraisingActive == false)
		{
			fundraisingScrollBox.enabled = true;
			fundraisingScrollBox.SetBool("isHidden", false);
			//Debug.Log("Fundraising Menu Box is Open");
		}
	}

	public void closeFundraising()
	{
		fundraisingScrollBox.SetBool("isHidden", true);
		//Debug.Log("Fundraising Menu Box is Closed");

//		if(donationBox.enabled == true)
//		{
//			donationBox.SetBool("isHidden", true);
//			Debug.Log("Fundraising Menu Box is Closed");
//		}
	}

	public void openDonation()
	{
		donationSelectionBox.enabled = true;
		donationSelectionBox.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}

	public void closeDonation()
	{
		donationSelectionBox.SetBool("isHidden", true);
		//Debug.Log("Donation Menu Box is Closed");

		//		if(donationBox.enabled == true)
		//		{
		//			donationBox.SetBool("isHidden", true);
		//			Debug.Log("Fundraising Menu Box is Closed");
		//		}
	}

	public void openAid()
	{
		aidScrollBox.enabled = true;
		aidScrollBox.SetBool("isHidden", false);
	}

	public void closeAid()
	{
	 	aidScrollBox.SetBool("isHidden", true);
	}

	public void openSettings()
	{
		optionsBox.enabled = true;
		optionsBox.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}
	
	public void closeSettings()
	{
		optionsBox.SetBool("isHidden", true);
		//Debug.Log("Donation Menu Box is Closed");
	}

	public void openInfo()
	{
		buildingInfoBox.enabled = true;
		buildingInfoBox.SetBool("isHidden", false);
		//Debug.Log("buildingInfoBox Menu Box is Open");
	}
	
	public void closeInfo()
	{
		buildingInfoBox.SetBool("isHidden", true);
		//Debug.Log("buildingInfoBox Menu Box is Closed");
	}

	public void toggleWellbeingButton()
	{
		wellbeingButton.enabled = true;
		bool isHidden = wellbeingButton.GetBool("isHidden");
		wellbeingButton.SetBool("isHidden", !isHidden);

		if(isHidden)
		{
			//Debug.Log ("Wellbeing Menu is Open");
		}
		else if(!isHidden)
		{
			//Debug.Log ("Wellbeing Menu is Closed");
		}
	}

	void Start()
	{
		RectTransform transform = wellbeingButton.gameObject.transform as RectTransform;        
		Vector2 position = transform.anchoredPosition;
		position.y -= transform.rect.height;
		transform.anchoredPosition = position;
	}	
}
