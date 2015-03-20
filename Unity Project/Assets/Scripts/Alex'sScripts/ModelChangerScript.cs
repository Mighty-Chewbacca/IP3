using UnityEngine;
using System.Collections;

public class ModelChangerScript : MonoBehaviour 
{
	//this script is going to be the basis of the models changing (so far as i know ALL models will have 3 iterations, may add functionality
	//to choose the amount of models implemented.)

	//the script is going to have to change both the model as well as the texture, different from last year which was just a texture

	public Mesh level1Mesh, level2Mesh, level3Mesh;
	public Material level1Texture, level2Texture, level3Texture;
	public int currLevel = 1;
	private MeshFilter currMesh;
	private MeshRenderer currMaterial;

	private float timer = 2.6f;
	private bool isEmitting = false;
	//private Texture2D currTexture;

	// Use this for initialization
	void Start () 
	{
		currMesh = this.GetComponent<MeshFilter> ();
		currMaterial = this.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (currLevel == 1) 
		{
			currMesh.mesh = level1Mesh;
			currMaterial.material = level1Texture;
		}

		if (currLevel == 2) 
		{
			currMesh.mesh = level2Mesh;
			currMaterial.material = level2Texture;
		}

		if (currLevel == 3) 
		{
			currMesh.mesh = level3Mesh;
			currMaterial.material = level3Texture;
		}

		if (isEmitting == true)
		{
			if (timer > 0)
			{
				timer -= Time.deltaTime;
			}
			else 
			{
				currLevel++;
				isEmitting = false;
				timer = 2.6f;
			}
		}
	}

	public void changeMesh()
	{
		isEmitting = true;
		this.BroadcastMessage ("PlayAnimation");
	}
}
