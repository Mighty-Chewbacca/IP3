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
	public Animator aidSelectionBox;
	public Animator story1Animator;
	public Animator story2Animator;

	public void openFundraising()
	{
		if (StaticValuesScript.isFundraisingActive == false)
		{
			StartCoroutine(PlayButtonClick());
			fundraisingScrollBox.enabled = true;
			fundraisingScrollBox.SetBool("isHidden", false);
			//Debug.Log("Fundraising Menu Box is Open");
		}
	}

	public void closeFundraising()
	{
		StartCoroutine(PlayButtonClick());
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
		StartCoroutine(PlayButtonClick());
		donationSelectionBox.enabled = true;
		donationSelectionBox.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}

	public void closeDonation()
	{
		StartCoroutine(PlayButtonClick());
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
		StartCoroutine(PlayButtonClick());
		aidScrollBox.enabled = true;
		aidScrollBox.SetBool("isHidden", false);
	}

	public void closeAid()
	{
		StartCoroutine(PlayButtonClick());
	 	aidScrollBox.SetBool("isHidden", true);
	}

	public void openAidSelection()
	{
		StartCoroutine(PlayButtonClick());
		aidSelectionBox.enabled = true;
		aidSelectionBox.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}
	
	public void closeAidSelection()
	{
		StartCoroutine(PlayButtonClick());
		aidSelectionBox.SetBool("isHidden", true);
		//Debug.Log("Donation Menu Box is Closed");
		
		//		if(donationBox.enabled == true)
		//		{
		//			donationBox.SetBool("isHidden", true);
		//			Debug.Log("Fundraising Menu Box is Closed");
		//		}
	}

	public void openSettings()
	{
		StartCoroutine(PlayButtonClick());
		optionsBox.enabled = true;
		optionsBox.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}
	
	public void closeSettings()
	{
		StartCoroutine(PlayButtonClick());
		optionsBox.SetBool("isHidden", true);
		//Debug.Log("Donation Menu Box is Closed");
	}

	public void openStory1()
	{
		StartCoroutine(PlayButtonClick());
		story1Animator.enabled = true;
		story1Animator.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}
	
	public void closeStory1()
	{
		StartCoroutine(PlayButtonClick());
		story1Animator.SetBool("isHidden", true);
		//Debug.Log("Donation Menu Box is Closed");
	}

	public void openStory2()
	{
		StartCoroutine(PlayButtonClick());
		story2Animator.enabled = true;
		story2Animator.SetBool("isHidden", false);
		//Debug.Log("Donation Menu Box is Open");
	}
	
	public void closeStory2()
	{
		StartCoroutine(PlayButtonClick());
		story2Animator.SetBool("isHidden", true);
		//Debug.Log("Donation Menu Box is Closed");
	}

	public void openInfo()
	{
		StartCoroutine(PlayButtonClick());
		buildingInfoBox.enabled = true;
		buildingInfoBox.SetBool("isHidden", false);
		//Debug.Log("buildingInfoBox Menu Box is Open");
	}
	
	public void closeInfo()
	{
		StartCoroutine(PlayButtonClick());
		buildingInfoBox.SetBool("isHidden", true);
		//Debug.Log("buildingInfoBox Menu Box is Closed");
	}

	public void toggleWellbeingButton()
	{
		StartCoroutine(PlayButtonClick());
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

	IEnumerator PlayButtonClick()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
	}

	void Start()
	{
		RectTransform transform = wellbeingButton.gameObject.transform as RectTransform;        
		Vector2 position = transform.anchoredPosition;
		position.y -= transform.rect.height;
		transform.anchoredPosition = position;
	}	
}
