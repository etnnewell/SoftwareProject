using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControllerFromTut : MonoBehaviour {

	private InstantTrackingController trackerScript;
	//private GameObject ButtonsParent;

	// Use this for initialization
	void Start () {
		trackerScript = GameObject.Find ("Controller").gameObject.GetComponent<InstantTrackingController> ();
		trackerScript._gridRenderer.enabled = false;
	}
		
}
