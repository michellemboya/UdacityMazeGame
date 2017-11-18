using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;
	public static bool Collect;
	private static int count;
	public Text countText;

	void Start ()
	{
		count = 0;
		SetCountText ();

	}

    public void OnCoinClicked() {

		count = count + 1;
		SetCountText ();
        // Instantiate the CoinPoof Prefab where this coin is located
		Instantiate (coinPoof, transform.position, Quaternion.Euler (-90, 0, 0));
		Collect = true;
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }

	void SetCountText () {
		countText.text = "Score: " + count.ToString ();

}
}
