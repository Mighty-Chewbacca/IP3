using UnityEngine;
using System.Collections;

public class BuildingInfoScript : MonoBehaviour 
{
	//this script will contain the individual buldings info to be displayed!
	public string textBox1String, textBox2String, textBox3String, textBox4String, textBox5String, textBox6String;

	public bool isUpgradable = false;

	private KidScript myKid;
	private SchoolScript mySchool;
	private ModelChangerScript myModelChanger;
	private HouseControllerScript houseController;

	private GameObject upgradeableIcon;

	private SpriteRenderer myIconRenderer;
	private Component myUpgradeHalo;

	// Use this for initialization
	void Start () 
	{
		myKid = GetComponent<KidScript> ();
		myModelChanger = GetComponent<ModelChangerScript>();
		houseController = GameObject.Find ("Houses").GetComponent<HouseControllerScript>();
		mySchool = GameObject.Find ("School").GetComponent<SchoolScript>();
		upgradeableIcon = transform.Find ("upgradeIcon").gameObject;
		myIconRenderer = upgradeableIcon.GetComponent<SpriteRenderer>();
		myUpgradeHalo = upgradeableIcon.GetComponent("Halo");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if the house is less than or equal to the current highest upgrade level
		//and if the kid is fed both days
		//and if the kid is at school

		CheckIfCanUpgrade ();

	}

	public void CheckIfCanUpgrade ()
	{
		int currentUpgradeCost = 0;

		if (myModelChanger.gameObject.tag == "Housing") 
		{

			if(myModelChanger.getHouseLevel() == 1)
				currentUpgradeCost = StaticValuesScript.level1UpgradeCost;
			else if(myModelChanger.getHouseLevel() == 2)
				currentUpgradeCost = StaticValuesScript.level2UpgradeCost;
			else{currentUpgradeCost = 5000;} // stop them upgrading past 3

			if ((houseController.CheckHighestUpgrade () > myModelChanger.getHouseLevel () || houseController.CheckLowestUpgrade () == myModelChanger.getHouseLevel ())
			    && myKid.goingToSchool == true && mySchool.educationSupplies >= currentUpgradeCost) 
			{	
					isUpgradable = true;
					myUpgradeHalo.GetType ().GetProperty ("enabled").SetValue (myUpgradeHalo, true, null);
					myIconRenderer.enabled = true;
			} 
			else 
			{
				isUpgradable = false;
				myUpgradeHalo.GetType ().GetProperty ("enabled").SetValue (myUpgradeHalo, false, null);
				myIconRenderer.enabled = false;
			}

		}
		else  if (myModelChanger.gameObject.tag == "church" || myModelChanger.gameObject.tag == "well")
		{
			if(myModelChanger.getHouseLevel() == 1)
				currentUpgradeCost = StaticValuesScript.level2UpgradeCost;
			else if(myModelChanger.getHouseLevel() == 2)
				currentUpgradeCost = StaticValuesScript.level3UpgradeCost;
			else{currentUpgradeCost = 5000;} // stop them upgrading past 3

			if (houseController.CheckLowestUpgrade() > myModelChanger.getHouseLevel() && mySchool.educationSupplies >= currentUpgradeCost && mySchool.eligableForNewPupil == true)
			{
				isUpgradable = true;
				myUpgradeHalo.GetType ().GetProperty ("enabled").SetValue (myUpgradeHalo, true, null);
				myIconRenderer.enabled = true;
			} 
			else 
			{
				isUpgradable = false;
				myUpgradeHalo.GetType ().GetProperty ("enabled").SetValue (myUpgradeHalo, false, null);
				myIconRenderer.enabled = false;
			}
		}
		else  if (myModelChanger.gameObject.tag == "School")
		{
			ModelChangerScript theWell = GameObject.Find ("Wells").GetComponent<ModelChangerScript>();
			ModelChangerScript theChurch = GameObject.Find ("Church").GetComponent<ModelChangerScript>();

			if(myModelChanger.getHouseLevel() == 1)
				currentUpgradeCost = StaticValuesScript.level2UpgradeCost;
			else if(myModelChanger.getHouseLevel() == 2)
				currentUpgradeCost = StaticValuesScript.level3UpgradeCost;
			else{currentUpgradeCost = 5000;} // stop them upgrading past 3
			
			if (houseController.CheckLowestUpgrade() > myModelChanger.getHouseLevel() && mySchool.educationSupplies >= currentUpgradeCost && mySchool.eligableForNewPupil == true
			    && theWell.getHouseLevel() > myModelChanger.getHouseLevel() && theChurch.getHouseLevel() > myModelChanger.getHouseLevel())
			{
				isUpgradable = true;
				myUpgradeHalo.GetType ().GetProperty ("enabled").SetValue (myUpgradeHalo, true, null);
				myIconRenderer.enabled = true;
			} 
			else 
			{
				isUpgradable = false;
				myUpgradeHalo.GetType ().GetProperty ("enabled").SetValue (myUpgradeHalo, false, null);
				myIconRenderer.enabled = false;
			}
		}
	}
}
