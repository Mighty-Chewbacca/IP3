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

	private BuildingInfoScript currentBuilding;

	private Text text1, text2, text3, text4, text5, text6;

	// Use this for initialization
	void Start ()
	{
		defaultLookAt = Camera.main.transform.forward;
		defaultPosition = Camera.main.transform.position;
		defaultRotation = Camera.main.transform.rotation;

		myEventSystem = GameObject.Find ("EventSystem").GetComponent<EventSystem> ();
		myUIcontroller = GameObject.Find ("ManiSceneUIManager").GetComponent<MainGameUIScript> ();

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
		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (myEventSystem.IsPointerOverGameObject () == false) {

				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.gameObject.tag == "Housing") {
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);
						Debug.Log ("hit house");
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();

						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text3.text = currentBuilding.textBox3String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;
						text6.text = currentBuilding.textBox6String;

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

					if (hit.transform.gameObject.tag == "School") {
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);
						Debug.Log ("hit school");
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();
						
						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text3.text = currentBuilding.textBox3String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;
						text6.text = currentBuilding.textBox6String;

						hit.transform.gameObject.SendMessage("changeMesh");

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
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();

						hit.transform.gameObject.SendMessage("changeMesh");

						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text3.text = currentBuilding.textBox3String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;
						text6.text = currentBuilding.textBox6String;
						
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
						myUIcontroller.openInfo();
						currentBuilding = hit.transform.gameObject.GetComponent<BuildingInfoScript>();

						hit.transform.gameObject.SendMessage("changeMesh");

						text1.text = currentBuilding.textBox1String;
						text2.text = currentBuilding.textBox2String;
						text3.text = currentBuilding.textBox3String;
						text4.text = currentBuilding.textBox4String;
						text5.text = currentBuilding.textBox5String;
						text6.text = currentBuilding.textBox6String;
						
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
	}

	public void ResetCamPosition ()
	{
		Debug.Log ("resetting position of camera");
		Camera.main.transform.position = defaultPosition;
		Camera.main.transform.LookAt (defaultLookAt);
		Camera.main.transform.rotation = defaultRotation;
	}
}
