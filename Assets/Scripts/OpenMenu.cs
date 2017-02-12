using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour {

	public Canvas pauseMenu;
	//public Text pauseText;
	//public Button menuButton, noButton, yesButton;

	// Use this for initialization
	void Start () {
        pauseMenu.GetComponent<Canvas> ();
        pauseMenu.enabled = false;
		//pauseText.GetComponent<Text> ();
		//noButton.GetComponent<Button> ();
		//yesButton.GetComponent<Button> ();
	}

    public void MenuPress()
    {
        pauseMenu.enabled = true;
    }

    

    // Update is called once per frame
    void Update () {
	
	}
}
