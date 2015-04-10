using UnityEngine;
using System.Collections;

public class ModelChangerScript : MonoBehaviour 
{
	//this script is going to be the basis of the models changing (so far as i know ALL models will have 3 iterations, may add functionality
	//to choose the amount of models implemented.)

	private int houseLevel = 1;
	private float timer = 2.6f;
	private bool isEmitting = false;
	private SchoolScript mySchool;
	private bool isAbleToUpgrade = false;
	private MainGameUIScript mainUIController;

	public AudioClip dingSound;

	IEnumerator PlayDingSound()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
	}

	// Use this for initialization
	void Start () 
	{
		mySchool = GameObject.Find ("School").GetComponent<SchoolScript>();
		mainUIController = GameObject.Find("ManiSceneUIManager").GetComponent<MainGameUIScript>();
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
					if (gameObject.tag == "Housing")
					{
						mySchool.educationSupplies -= StaticValuesScript.level1UpgradeCost;

						StartCoroutine(PlayDingSound());
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

					if (gameObject.tag == "School")
					{
						mySchool.educationSupplies -= StaticValuesScript.level2UpgradeCost;

						StartCoroutine(PlayDingSound());
						GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/SchoolTier2"));
						go.transform.position = this.transform.position;
						go.transform.parent = this.transform;

						Vector3 position = go.transform.position;
						position.y += 205;
						position.x += 20;
						position.z += -88;
						go.transform.position = position;
						
						houseLevel ++;
						foreach(Transform child in transform)
						{
							if (child.gameObject.tag == "schoolT1")
							{	
								Destroy(child.gameObject);
							}
						}

						mainUIController.openStory1();
					}

					if (gameObject.tag == "well")
					{
						mySchool.educationSupplies -= StaticValuesScript.level2UpgradeCost;

						StartCoroutine(PlayDingSound());
						GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/WellTier2"));
						go.transform.position = this.transform.position;
						go.transform.parent = this.transform;
						
						Vector3 position = go.transform.position;
						position.z += 40;
						go.transform.position = position;
						
						houseLevel ++;
						foreach(Transform child in transform)
						{
							if (child.gameObject.tag == "wellT1")
							{	
								Destroy(child.gameObject);
							}
						}
					}

					if (gameObject.tag == "church")
					{
						mySchool.educationSupplies -= StaticValuesScript.level2UpgradeCost;

						StartCoroutine(PlayDingSound());
						GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/ChurchTier2"));
						go.transform.position = this.transform.position;
						go.transform.parent = this.transform;
						
						Vector3 position = go.transform.position;
						position.z += 40;
						go.transform.position = position;
						
						houseLevel ++;
						foreach(Transform child in transform)
						{
							if (child.gameObject.tag == "churchT1")
							{	
								Destroy(child.gameObject);
							}
						}
					}
				} 
				else if (houseLevel == 2)
				{
					if (gameObject.tag == "Housing")
					{
						mySchool.educationSupplies -= StaticValuesScript.level2UpgradeCost;

						StartCoroutine(PlayDingSound());
					GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/HouseTier3"));
					go.transform.position = this.transform.position;
					go.transform.parent = this.transform;

					Vector3 position = go.transform.position;
					position.y += 42;
					go.transform.position = position;

					houseLevel ++;
					foreach(Transform child in transform)
					{
						if (child.gameObject.tag == "houseT2")
						{
							Destroy(child.gameObject);
						}
					}
					}

					if (gameObject.tag == "School")
					{
						mySchool.educationSupplies -= StaticValuesScript.level3UpgradeCost;

						StartCoroutine(PlayDingSound());
						GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/SchoolTier3"));
						go.transform.position = this.transform.position;
						go.transform.parent = this.transform;

						Vector3 position = go.transform.position;
						position.y += 198;
						position.x += 20;
						position.z += -105;
						go.transform.position = position;
						
						houseLevel ++;
						foreach(Transform child in transform)
						{
							if (child.gameObject.tag == "schoolT2")
							{
								Destroy(child.gameObject);
							}
						}

						mainUIController.openStory2();
					}

					if (gameObject.tag == "well")
					{
						mySchool.educationSupplies -= StaticValuesScript.level3UpgradeCost;

						StartCoroutine(PlayDingSound());
						GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/WellTier3"));
						go.transform.position = this.transform.position;
						go.transform.parent = this.transform;
						
						Vector3 position = go.transform.position;
						position.x += 20;
						position.z += 20;
						go.transform.position = position;
						
						houseLevel ++;
						foreach(Transform child in transform)
						{
							if (child.gameObject.tag == "wellT2")
							{
								Destroy(child.gameObject);
							}
						}
					}

					if (gameObject.tag == "church")
					{
						mySchool.educationSupplies -= StaticValuesScript.level3UpgradeCost;

						StartCoroutine(PlayDingSound());
						GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/ChurchTier3"));
						go.transform.position = this.transform.position;
						go.transform.parent = this.transform;
						
						Vector3 position = go.transform.position;
						position.x += 20;
						position.z += 50;
						go.transform.position = position;
						
						houseLevel ++;
						foreach(Transform child in transform)
						{
							if (child.gameObject.tag == "churchT2")
							{
								Destroy(child.gameObject);
							}
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
