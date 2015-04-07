using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InputScript : MonoBehaviour
{
	private Vector3 defaultLookAt, defaultPosition;
	private Quaternion defaultRotation;
	private UnityEngine.EventSystems.EventSystem myEventSystem;
	private MainGameUIScript myUIcontroller;

	// Use this for initialization
	void Start ()
	{
		defaultLookAt = Camera.main.transform.forward;
		defaultPosition = Camera.main.transform.position;
		defaultRotation = Camera.main.transform.rotation;

		myEventSystem = GameObject.Find ("EventSystem").GetComponent<EventSystem> ();
		myUIcontroller = GameObject.Find ("ManiSceneUIManager").GetComponent<MainGameUIScript> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (myEventSystem.IsPointerOverGameObject () == false) {

				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.gameObject.tag == "Housing") {
						//do all hit detection for houses in here
						//Destroy(hit.transform.gameObject);
						Debug.Log ("hit house");
						myUIcontroller.openInfo();
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
