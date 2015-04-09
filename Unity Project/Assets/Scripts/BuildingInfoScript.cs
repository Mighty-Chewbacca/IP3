using UnityEngine;
using System.Collections;

public class BuildingInfoScript : MonoBehaviour 
{
	//this script will contain the individual buldings info to be displayed!
	public string textBox1String, textBox2String, textBox3String, textBox4String, textBox5String, textBox6String;

	public bool isUpgradable = false;

	private KidScript myKid;
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

	public void CheckIfCanUpgrade()
	{
		if(houseController.CheckHighestUpgrade() > myModelChanger.getHouseLevel() || houseController.CheckLowestUpgrade() == myModelChanger.getHouseLevel())
		{
			isUpgradable = true;
			myUpgradeHalo.GetType().GetProperty("enabled").SetValue(myUpgradeHalo, true, null);
			myIconRenderer.enabled = true;
		}
		else
		{
			isUpgradable = false;
			myUpgradeHalo.GetType().GetProperty("enabled").SetValue(myUpgradeHalo, false, null);
			myIconRenderer.enabled = false;
		}
	}
}
