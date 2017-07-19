using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps : MonoBehaviour {
	float deltaTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
	}

	void OnGUI(){
		bool showfps = false;
		if (showfps){
			float msec = deltaTime * 1000.0f;
		    float fps = 1.0f / deltaTime;
		    string text = string.Format ("{0:0.0} ms ({1:0.} fps", msec, fps);
		    print (text);
		}
	}	
}
