using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{
	private Vector3 defaultLookAt, defaultPosition;
	private Quaternion defaultRotation;
	private UnityEngine.EventSystems.EventSystem myEventSystem;
	private MainGameUIScript myUIcontroller;

	private BuildingInfoScript currentBuilding = null;
	private string currentHit = "none";

	private SchoolScript mySchool;
	private KidScript myKid;
	private ModelChangerScript schoolChanger;

	private Text text1, text2, text3, text4, text5, text6;
	private Button upgradeButton;

	private Button story1Button, story2Button;

	// Use this for initialization
	void Start ()
	{
		defaultLookAt = Camera.main.transform.forward;
		defaultPosition = Camera.main.transform.position;
		defaultRotation = Camera.main.transform.rotation;

		mySchool = GameObject.Find ("School").GetComponent<SchoolScript> ();
		schoolChanger = GameObject.Find ("School").GetComponent<ModelChangerScript> ();
		myEventSystem = GameObject.Find ("EventSystem").GetComponent<EventSystem> ();
		myUIcontroller = GameObject.Find ("ManiSceneUIManager").GetComponent<MainGameUIScript> ();

		upgradeButton = GameObject.Find ("upgradeButton").GetComponent<Button> ();
		story1Button = GameObject.Find ("story1Button").GetComponent<Button> ();
		story2Button = GameObject.Find ("story2Button").GetComponent<Button> ();

		story1Button.interactable = false;
		story2Button.interactable = false;

		text1 = GameObject.Find ("buildingTB1").GetComponent<Text> ();
		text2 = GameObject.Find ("buildingTB2").GetComponent<Text> ();
		text3 = GameObject.Find ("buildingTB3").GetComponent<Text> ();
		text4 = GameObject.Find ("buildingTB4").GetComponent<Text> ();
		text5 = GameObject.Find ("buildingTB5").GetComponent<Text> ();
		text6 = GameObject.Find ("buildingTB6").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (schoolChanger.getHouseLevel() >1)
			story1Button.interactable = true;

		if (schoolChanger.getHouseLevel() >2)
			story2Button.interactable = true;

		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (myEventSystem.IsPointerOverGameObject () == false) {

				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.gameObject.tag == "Housing") 
					{
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);


						Debug.Log ("hit house");
						currentHit = "House";
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();
						myKid = currentBuilding.GetComponent<KidScript>();

						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;

						//hit.transform.gameObject.SendMessage("changeMesh");
						//send the houses info, should be able to access it here in hit
						foreach (Transform child in hit.transform.gameObject.transform) {
							Debug.Log ("looping children");
							if (child.gameObject.tag == "cameraPosition") {
								Camera.main.transform.position = child.transform.position;
								Camera.main.transform.LookAt (hit.transform.gameObject.transform.position);
								Debug.Log ("attempted to change position of camera");
							}
						}
					}

					if (hit.transform.gameObject.tag == "School") {
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);
						Debug.Log ("hit school");
						currentHit = "School";
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();
						
						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text3.text = currentBuilding.textBox3String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;

						//hit.transform.gameObject.SendMessage("changeMesh");

						//this code will send the model change message, need this for talking to object hit.transform.gameObject.SendMessage("changeMesh");
						//send the houses info, should be able to access it here in hit
						foreach (Transform child in hit.transform.gameObject.transform) {
							Debug.Log ("looping children");
							if (child.gameObject.tag == "cameraPosition") {
								Camera.main.transform.position = child.transform.position;
								Camera.main.transform.LookAt (hit.transform.gameObject.transform.position);
								Debug.Log ("attempted to change position of camera");
							}
						}
					}

					if (hit.transform.gameObject.tag == "well") {
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);
						Debug.Log ("hit well");
						currentHit = "Well";
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();

						//hit.transform.gameObject.SendMessage("changeMesh");

						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text3.text = currentBuilding.textBox3String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;
						
						//this code will send the model change message, need this for talking to object hit.transform.gameObject.SendMessage("changeMesh");
						//send the houses info, should be able to access it here in hit
						foreach (Transform child in hit.transform.gameObject.transform) {
							Debug.Log ("looping children");
							if (child.gameObject.tag == "cameraPosition") {
								Camera.main.transform.position = child.transform.position;
								Camera.main.transform.LookAt (hit.transform.gameObject.transform.position);
								Debug.Log ("attempted to change position of camera");
							}
						}
					}

					if (hit.transform.gameObject.tag == "church") {
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);
						Debug.Log ("hit church");
						currentHit = "Church";
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();

						//hit.transform.gameObject.SendMessage("changeMesh");

						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;

						//text3.text = currentBuilding.textBox3String;

						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;
						
						//this code will send the model change message, need this for talking to object hit.transform.gameObject.SendMessage("changeMesh");
						//send the houses info, should be able to access it here in hit
						foreach (Transform child in hit.transform.gameObject.transform) {
							Debug.Log ("looping children");
							if (child.gameObject.tag == "cameraPosition") {
								Camera.main.transform.position = child.transform.position;
								Camera.main.transform.LookAt (hit.transform.gameObject.transform.position);
								Debug.Log ("attempted to change position of camera");
							}
						}
					}
				}
			}
		}

		if (currentHit == "Church")
		{

			if (StaticValuesScript.isFundraisingActive) 
			{
				text3.text = "Currently Fundraising:" + StaticValuesScript.currentFundraising;
			}
			if (!StaticValuesScript.isFundraisingActive) 
			{
				text3.text = "Not Currently Fundraising:";
			}

			if (StaticValuesScript.isDonationActive) 
			{
				text4.text = "Currently Donating:" + StaticValuesScript.currentDonation;
			}
			if (!StaticValuesScript.isDonationActive) 
			{
				text4.text = "Not Currently Donating:";
			}
			
		}

		if (currentHit == "School")
		{
			text2.text = "No. of Pupils: " + mySchool.attendingPopulation;
			text3.text = "No. meals needed: " + mySchool.attendingPopulation;
			text4.text = "No. meals stored: " + mySchool.mealsStored;
			text5.text = "No. of Education Supplies: " + mySchool.educationSupplies;
		}

		if (currentHit == "House")
		{

			text3.text = "Going to school? " + myKid.goingToSchool.ToString();

			text5.text = "Fed Today? " + myKid.fedToday;
		}

		if (currentBuilding != null) 
		{
			if (currentBuilding.isUpgradable) 
			{
				upgradeButton.interactable = true;
			} 
			else 
			{
				upgradeButton.interactable = false;
			}
		}

		text6.text = "Upgrade Available?  " + currentBuilding.isUpgradable.ToString();
	}
	
	public void ResetCamPosition ()
	{
		Debug.Log ("resetting position of camera");
		Camera.main.transform.position = defaultPosition;
		Camera.main.transform.LookAt (defaultLookAt);
		Camera.main.transform.rotation = defaultRotation;
	}


	public void UpgradeCurrentBuilding()
	{
		currentBuilding.gameObject.SendMessage ("changeMesh");
	}
}
