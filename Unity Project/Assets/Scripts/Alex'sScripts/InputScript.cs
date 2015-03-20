using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform.gameObject.tag == "Housing")
				{
					//do all hit detection for houses in here
					//Destroy(hit.transform.gameObject);
					Debug.Log("hit house");
				}
			}
		}
	}
}
