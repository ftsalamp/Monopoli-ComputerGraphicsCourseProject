using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuBehaviourScript : MonoBehaviour {

	public Canvas quitMenu, startMenu, buyDialog,rentDialog;

	// Use this for initialization
	void Start () {
		startMenu = startMenu.GetComponent<Canvas> ();
		quitMenu=quitMenu.GetComponent<Canvas>();
        buyDialog = startMenu.GetComponent<Canvas>();
        rentDialog = startMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;
        buyDialog.enabled = false;
        rentDialog.enabled = false;
    }

	public void ExitPress(){
		startMenu.enabled=false;
		quitMenu.enabled = true;
	}

	public void NoPress(){
		quitMenu.enabled = false;
		startMenu.enabled=true;
	}

	public void StartLevel(){
		SceneManager.LoadScene (1);
	}

	public void ExitGame(){
		Application.Quit();
	}


	// Update is called once per frame
	void Update () {
	
	}
}
