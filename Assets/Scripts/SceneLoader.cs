﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour {

	public void loadGameScene()
	{
		SceneManager.LoadScene ("Scene1");
	}
	public void loadCreditScene()
	{
		Debug.Log ("Creditos");
	}
	public void exit()
	{
		Application.Quit();
	}
}
