using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseGameMenuBehaviourScript : MonoBehaviour {

	public Canvas pauseMenu;
	public Button exitButton, continueButton;

	// Use this for initialization
	void Start () {
		pauseMenu = pauseMenu.GetComponent<Canvas> ();
		exitButton = exitButton.GetComponent<Button> ();
		continueButton = continueButton.GetComponent<Button> ();
		pauseMenu.enabled = false;
	}

	public void ContinuePress(){
		pauseMenu.enabled=false;
	}

	public void ExitLevel(){
		SceneManager.LoadScene (0);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
