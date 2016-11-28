using UnityEngine;
using System.Collections;

public class ObjectRecycler : MonoBehaviour {

	[SerializeField] private float maxY;
	[SerializeField] private float minY;
	[SerializeField] private float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < maxY) {
			transform.position += new Vector3 (0, speed, 0);
		} else {
			transform.position = new Vector3 (0, minY, 0);
		}
	}
}
