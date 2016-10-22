using UnityEngine;
using System.Collections;

public class menuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CheckGameStatus();
	}
	

    void CheckGameStatus() {

        if(PlayerPrefs.GetInt("GameAlreadyStarted") == 0) // A game never started
        {
            // disable continue button
        }
    }

   public void StartNewGame() {
        if(PlayerPrefs.GetInt("GameAlreadyStarted") == 1)
        {
            // Alert : Are you sure ? Previous pets will be erased
        }

        PlayerPrefs.SetInt("GameAlreadyStarted", 1);
        //Load New Game Scene
    }

    public void ContinueGame() {

        //Load Main Game Scene
    }

}
