using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollidersManager : MonoBehaviour {

    public Canvas quitMenu, startMenu;
    // Use this for initialization
    void Start () {
        startMenu = startMenu.GetComponent<Canvas>();
        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;
    }

    public void ExitPress()
    {
        startMenu.enabled = false;
        quitMenu.enabled = true;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startMenu.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update () {
	
	}
}
