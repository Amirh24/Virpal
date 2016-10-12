using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ScanAgainButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ScanAgain()
    {
        //  SceneManager.LoadScene("Vuforia-3-UserDefinedTargets", LoadSceneMode.Additive);
        SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
       // Application.LoadLevel(2);
    }

    
}
