using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuButtonPressed : MonoBehaviour {

	public Canvas pauseMenu;
	public Button menuButton;

	// Use this for initialization
	void Start () {
		pauseMenu = pauseMenu.GetComponent<Canvas> ();
		menuButton = menuButton.GetComponent<Button> ();
	}

	public void MenuPress(){
		pauseMenu.enabled=true;
		menuButton.enabled=true;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
