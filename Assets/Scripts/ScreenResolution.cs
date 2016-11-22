using UnityEngine;
using System.Collections;

public class ScreenResolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Show screen dimensions
		Debug.Log ("Width :" + Screen.width.ToString() + ". Height :" + Screen.height.ToString());
	}
}
