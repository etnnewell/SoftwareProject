﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEditUserProfile : MonoBehaviour {

	// Use this for initialization
	public void loadscene (string a) {
		SceneManager.LoadScene(a);

	}
}
