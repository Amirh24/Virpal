using UnityEngine;
using System.Collections;
using System;

public class Bootstraper : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        Watcher.Init(this);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
