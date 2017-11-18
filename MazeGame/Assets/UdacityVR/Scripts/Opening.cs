using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour {

	public GameObject helloUI, rulesUI;

	void Start()

	{

		ToggleUI();

	}

	public void GotoMaze()

		{
		SceneManager.LoadScene ("A Maze");

	}

	public void ToggleUI()
	{
		helloUI.SetActive(!helloUI.activeSelf);
		rulesUI.SetActive(!rulesUI.activeSelf);
	}
				
}