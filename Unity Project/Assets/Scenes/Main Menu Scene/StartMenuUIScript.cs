using UnityEngine;
using System.Collections;

public class StartMenuUIScript : MonoBehaviour {

	public void LoadGame()
	{
		Application.LoadLevel("MainScene");
		Debug.Log("Main Game Scene Is Loaded");
	}

}
