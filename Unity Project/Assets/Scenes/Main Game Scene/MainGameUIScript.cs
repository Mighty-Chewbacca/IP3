using UnityEngine;
using System.Collections;

public class MainGameUIScript : MonoBehaviour {

	public Animator dialogueBox;
	public Animator donationBox;
	public Animator wellbeingButton;

	public void openFundraising()
	{
		dialogueBox.enabled = true;
		dialogueBox.SetBool("isHidden", false);
		Debug.Log("Fundraising Menu Box is Open");
	}

	public void closeFundraising()
	{
		dialogueBox.SetBool("isHidden", true);
		Debug.Log("Fundraising Menu Box is Closed");

		if(donationBox.enabled == true)
		{
			donationBox.SetBool("isHidden", true);
			Debug.Log("Fundraising Menu Box is Closed");
		}
	}

	public void openDonation()
	{
		donationBox.enabled = true;
		donationBox.SetBool("isHidden", false);
		Debug.Log("Donation Menu Box is Open");
	}

	public void closeDonation()
	{
		donationBox.SetBool("isHidden", true);
		Debug.Log("Donation Menu Box is Closed");
	}

	public void toggleWellbeingButton()
	{
		wellbeingButton.enabled = true;
		bool isHidden = wellbeingButton.GetBool("isHidden");
		wellbeingButton.SetBool("isHidden", !isHidden);

		if(isHidden)
		{
			Debug.Log ("Wellbeing Menu is Open");
		}
		else if(!isHidden)
		{
			Debug.Log ("Wellbeing Menu is Closed");
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
