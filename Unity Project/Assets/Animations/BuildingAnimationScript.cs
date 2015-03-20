using UnityEngine;
using System.Collections;

public class BuildingAnimationScript : MonoBehaviour 
{

	//the script that will control the animation of the building.

	Animator animation;
	bool playAnimation = false;
	private float timer = 2.6f;

	// Use this for initialization
	void Start () 
	{
		animation = this.GetComponent<Animator> ();

		animation.SetBool ("isBuilding", false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		animation.SetBool ("isBuilding", playAnimation);

		if (playAnimation == true)
		{
			if (timer > 0)
			{
				timer -= Time.deltaTime;
				//Debug.Log(delayTime);
			}
			else 
			{
				playAnimation = false;
				timer = 2.6f;
			}
		}
	}

	public void PlayAnimation()
	{
		playAnimation = true;
	}
}
