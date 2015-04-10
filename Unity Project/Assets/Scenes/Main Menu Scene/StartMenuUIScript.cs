using UnityEngine;
using System.Collections;

public class StartMenuUIScript : MonoBehaviour {

	public void LoadGame()
	{
		StartCoroutine(PlayButtonClick());
		Application.LoadLevel("MainScene");
		Debug.Log("Main Game Scene Is Loaded");
	}

	public void donateButton()
	{
		StartCoroutine(PlayButtonClick());
	}
	public void shareButton()
	{
		StartCoroutine(PlayButtonClick());
	}
	public void quitButton()
	{
		StartCoroutine(PlayButtonClick());
		Application.Quit();
	}
	public void settingsButton()
	{
		StartCoroutine(PlayButtonClick());
	}
	public void trophyButton()
	{
		StartCoroutine(PlayButtonClick());
	}
	IEnumerator PlayButtonClick()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
	}
}
