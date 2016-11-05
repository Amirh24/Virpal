using UnityEngine;
using System.Collections;

public class bootGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //check hygiene level
        PlayerPrefs.GetString("lastToilet");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
