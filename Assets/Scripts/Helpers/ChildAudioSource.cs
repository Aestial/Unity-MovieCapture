using UnityEngine;
using System.Collections;

public class ChildAudioSource : MonoBehaviour {

	private AudioSource parentSource;
	private AudioSource aSource;

	// Use this for initialization
	void Start () {
		aSource = GetComponent<AudioSource> ();
		parentSource = transform.parent.GetComponent<AudioSource> ();
		Debug.Log (aSource);
		Debug.Log (parentSource);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (parentSource.volume);
		aSource.volume = parentSource.volume;
	}
}
