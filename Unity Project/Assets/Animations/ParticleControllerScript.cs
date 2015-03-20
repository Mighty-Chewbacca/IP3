using UnityEngine;
using System.Collections;

public class ParticleControllerScript : MonoBehaviour
{
	ParticleSystem myParticles;
	private bool isEmitting = false;
	private float timer = 2.6f;

	// Use this for initialization
	void Start () 
	{
		myParticles = this.GetComponent<ParticleSystem> ();
		myParticles.emissionRate = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isEmitting == true)
		{
			if (timer > 0)
			{
				timer -= Time.deltaTime;
			}
			else 
			{
				myParticles.emissionRate = 0;
				isEmitting = false;
				timer = 2.6f;

			}
		}
	}

	public void PlayAnimation()
	{
		myParticles.emissionRate = 10;
		isEmitting = true;
	}
}
