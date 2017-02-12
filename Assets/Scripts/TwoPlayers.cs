using UnityEngine;
using UnityEngine.UI;

public class TwoPlayers : MonoBehaviour {

	private bool user1, user2;
	private int moneyUser1,moneyUser2;
    private System.Random rnd;
    public Text diceResult;
    public Image dice;
    public bool User1
    {
        get
        {
            return user1;
        }

        set
        {
            user1 = value;
        }
    }

    public bool User2
    {
        get
        {
            return user2;
        }

        set
        {
            user2 = value;
        }
    }

    // Use this for initialization
    void Start () {
		User1 = true;
		User2 = false;
		moneyUser1 = 5000;
		moneyUser2 = 5000;
        rnd = new System.Random();
        diceResult.GetComponent<Text>();
        dice.GetComponent <Image>();
    }
	
    void ChangePlayer()
    {
        if (User1 == true)
        {
            User1 = false;
            User2 = true;
        }
        else
        {
            User2 = false;
            User1 = true;
        }
    }
	
    private int getDiceNum()
    {
        return rnd.Next(1, 5);
    }
    public void rollDice()
    {
        int diceNum=getDiceNum();
        diceResult.text = diceNum.ToString();
        diceResult.enabled = true;
        System.Threading.Thread.Sleep(2500);
        diceResult.enabled = false;
        Movement.rest = diceNum;
        Movement.move = true;

    }

    // Update is called once per frame
    void Update () {
	
	}
}
