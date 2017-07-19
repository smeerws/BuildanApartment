using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Intersect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bool intersections = true;
		if (intersections) {
			showIntersections ("kitchenarea");
			showIntersections ("livingarea");
			showIntersections ("diningarea");
			showIntersections ("workingarea");
		}

		//showNotstaticObjects ();

		print("All " + Resources.FindObjectsOfTypeAll<UnityEngine.Object>().Length);
		print("Textures " + Resources.FindObjectsOfTypeAll<Texture>().Length);
		print("AudioClips " + Resources.FindObjectsOfTypeAll<AudioClip>().Length);
		print("Meshes " + Resources.FindObjectsOfTypeAll<Mesh>().Length);
		print("Materials " + Resources.FindObjectsOfTypeAll<Material>().Length);
		print("GameObjects " + Resources.FindObjectsOfTypeAll<GameObject>().Length);
		print("Components " + Resources.FindObjectsOfTypeAll<Component>().Length);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void showNotstaticObjects(){

		foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
		{
			if (go.isStatic) {
				continue;
			}

			if (go.activeInHierarchy) {
				print ("not static objects in scene----:" + go.name);
			} else {
				print (go.name + " " + go.hideFlags);
			}
		}
	}
	void showIntersections(string taginscene){
		GameObject[] allObjects = (GameObject[])GameObject.FindGameObjectsWithTag (taginscene); //returns GameObject[] X
		print ("objects in scene----:" + allObjects.Length + " with Tag: " + taginscene);

		List<String> intersections = new List<String> ();

		for (int i = 0; i < allObjects.Length; i++) {
			var o1 = allObjects [i].GetComponent<Renderer> ().bounds;
			for (int j = i + 1; j < allObjects.Length; j++) {
				var o2 = allObjects [j].GetComponent<Renderer> ().bounds;
				if (o1.Intersects (o2)) {
					intersections.Add (taginscene +" intersection: " + allObjects [i].name + " with " + allObjects [j].name);
				}
			}
		}
			
		if (intersections.Count == 0) {
			print (taginscene + " :) no intersections ");
		} else {
			foreach (String entry in intersections) {
				print (entry);
			}
		}
	}
}
