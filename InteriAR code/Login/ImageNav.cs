using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.IO;
using UnityEngine.UI;

public class ImageNav : MonoBehaviour {

	public Image img;

	public GameObject imgnotexist;

	public Text txt;
	public Text errormsg;


	public static int counter = 0;
	// Use this for initialization
	void Start () {
		if (counter == 0) {
			txt.text = counter.ToString ();
			imgnotexist.SetActive (true);
			errormsg.text = "Your Gallery";
		}

		try{
			if (counter == 1) {
				imgnotexist.SetActive(false);
				string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
				byte[] byteArray = File.ReadAllBytes (dir1);
				Texture2D texture = new Texture2D (8, 8);
				texture.LoadImage (byteArray);
				Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
				img.sprite = s;

				txt.text = counter.ToString();
			}

		}
		catch(FileNotFoundException e) {
				txt.text = counter.ToString();
				imgnotexist.SetActive (true);
				errormsg.text = "No image found in slot " + counter;

				Debug.Log ("file not found");
		}

		try{
			if (counter == 2) {
				imgnotexist.SetActive(false);
				string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
				byte[] byteArray = File.ReadAllBytes (dir1);
				Texture2D texture = new Texture2D (8, 8);
				texture.LoadImage (byteArray);
				Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
				img.sprite = s;

				txt.text = counter.ToString();
			}

		}
		catch(FileNotFoundException e) {
			txt.text = counter.ToString();
			imgnotexist.SetActive (true);
			errormsg.text = "No image found in slot " + counter;

			Debug.Log ("file not found");
		}

		try{
			if (counter == 3) {
				imgnotexist.SetActive(false);
				string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
				byte[] byteArray = File.ReadAllBytes (dir1);
				Texture2D texture = new Texture2D (8, 8);
				texture.LoadImage (byteArray);
				Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
				img.sprite = s;

				txt.text = counter.ToString();
			}

		}
		catch(FileNotFoundException e) {
			txt.text = counter.ToString();
			imgnotexist.SetActive (true);
			errormsg.text = "No image found in slot " + counter;

			Debug.Log ("file not found");
		}
		try{
			if (counter == 4) {
				imgnotexist.SetActive(false);
				string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
				byte[] byteArray = File.ReadAllBytes (dir1);
				Texture2D texture = new Texture2D (8, 8);
				texture.LoadImage (byteArray);
				Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
				img.sprite = s;

				txt.text = counter.ToString();
			}

		}
		catch(FileNotFoundException e) {
			txt.text = counter.ToString();
			imgnotexist.SetActive (true);
			errormsg.text = "No image found in slot " + counter;

			Debug.Log ("file not found");
		}

		try{
			if (counter == 5) {
				imgnotexist.SetActive(false);
				string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
				byte[] byteArray = File.ReadAllBytes (dir1);
				Texture2D texture = new Texture2D (8, 8);
				texture.LoadImage (byteArray);
				Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
				img.sprite = s;

				txt.text = counter.ToString();
			}

		}
		catch(FileNotFoundException e) {
			txt.text = counter.ToString();
			imgnotexist.SetActive (true);
			errormsg.text = "No image found in slot " + counter;

			Debug.Log ("file not found");
		}
		try{
			if (counter == 6) {
				imgnotexist.SetActive(false);
				string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
				byte[] byteArray = File.ReadAllBytes (dir1);
				Texture2D texture = new Texture2D (8, 8);
				texture.LoadImage (byteArray);
				Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
				img.sprite = s;

				txt.text = counter.ToString();
			}

		}
		catch(FileNotFoundException e) {
			txt.text = counter.ToString();
			imgnotexist.SetActive (true);
			errormsg.text = "No image found in slot " + counter;

			Debug.Log ("file not found");
		}

	}

	public void rightarrow() {
		Debug.Log (counter);

		try{
		if (counter < 6) {
				imgnotexist.SetActive(false);

			counter++;
			string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
			byte[] byteArray = File.ReadAllBytes (dir1);
			Texture2D texture = new Texture2D (8, 8);
			texture.LoadImage (byteArray);
			Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
			img.sprite = s;

			txt.text = counter.ToString();
		}

		}
		catch(FileNotFoundException e) {
			if (counter < 7) {
				txt.text = counter.ToString();
				imgnotexist.SetActive (true);
				errormsg.text = "No image found in slot " + counter;

				Debug.Log ("file not found");
			}
		}

	}

	public void leftarrow() {
		Debug.Log (counter);
		try {
		if (counter > 0) {
				imgnotexist.SetActive(false);

			counter--;
			string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";
			byte[] byteArray = File.ReadAllBytes (dir1);
			Texture2D texture = new Texture2D (8, 8);
			texture.LoadImage (byteArray);
			Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
			img.sprite = s;

			txt.text = counter.ToString();
			}
		}
		catch(FileNotFoundException e) {
			if (counter > 0) {
				
				txt.text = counter.ToString();

				imgnotexist.SetActive (true);
				errormsg.text = "No image found in slot " + counter;

				Debug.Log ("file not found");
			} else if (counter == 0) {
				txt.text = "0";

				imgnotexist.SetActive (true);
				errormsg.text = "Your Gallery";


			}
		}

	}


	public void deletebtn() {

		try {

			if(counter != 0) {
			imgnotexist.SetActive(false);

			string dir1 = Application.persistentDataPath + "/" + "Screenshot_" + counter + ".jpg";

			if (File.Exists (dir1)) {

				File.Delete (dir1);

			} 
			byte[] byteArray = File.ReadAllBytes (dir1);
			Texture2D texture = new Texture2D (8, 8);
			texture.LoadImage (byteArray);
			Sprite s = Sprite.Create (texture, new Rect (0, 0, texture.width, texture.height), Vector2.zero, 1f);
			img.sprite = s;
			}
	}
		catch(FileNotFoundException e) {
			txt.text = counter.ToString();
			errormsg.text = "No image found in slot " + counter;

			imgnotexist.SetActive(true);
			Debug.Log ("file not found");

		}
	}



}