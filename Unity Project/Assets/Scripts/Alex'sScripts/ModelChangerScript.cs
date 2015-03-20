using UnityEngine;
using System.Collections;

public class ModelChangerScript : MonoBehaviour 
{
	//this script is going to be the basis of the models changing (so far as i know ALL models will have 3 iterations, may add functionality
	//to choose the amount of models implemented.)

	private int houseLevel = 1;
	private float timer = 2.6f;
	private bool isEmitting = false;
	//private Texture2D currTexture;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isEmitting == true && houseLevel < 3)
		{
			if (timer > 0)
			{
				timer -= Time.deltaTime;
			}
			else 
			{
				if (houseLevel == 1)
				{
					GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/HouseTier2"));
					go.transform.position = this.transform.position;
					go.transform.parent = this.transform;
					houseLevel ++;
					foreach(Transform child in transform)
					{
						if (child.gameObject.tag == "houseT1")
						{
							Destroy(child.gameObject);
						}
					}
				} 
				else if (houseLevel == 2)
				{
					GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/HouseTier3"));
					go.transform.position = this.transform.position;
					go.transform.parent = this.transform;
					houseLevel ++;
					foreach(Transform child in transform)
					{
						if (child.gameObject.tag == "houseT2")
						{
							Destroy(child.gameObject);
						}
					}
				}
						
				isEmitting = false;
				timer = 2.6f;
			}
		}
	}

	public void changeMesh()
	{
		if (houseLevel < 3)
		{
			isEmitting = true;
			this.BroadcastMessage ("PlayAnimation");
		}
	}

	public int getHouseLevel()
	{
		return houseLevel;
	}
}
