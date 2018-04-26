using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARDecoratorORUser : MonoBehaviour {

	public static int counter = 0;

	public void loadAR() {

		Scene current = SceneManager.GetActiveScene ();

		string sceneName = current.name;

		if (sceneName == "userProfile") {

			counter = 1;
			SceneManager.LoadScene ("main");


		} 
		if (sceneName == "decoratorProfileLogin") {

			counter = 2;
			SceneManager.LoadScene ("main");

		}
	}

	public void loadProfile() {

		Debug.Log (counter);
		if (counter == 1) {


			SceneManager.LoadScene ("userProfile");

		} else if (counter == 2) {


			SceneManager.LoadScene ("decoratorProfileLogin");


		}


	}

}
