using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{
	public GameObject signpost;	
	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
		SceneManager.LoadScene ("A Maze");
	}
}