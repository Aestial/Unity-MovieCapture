using UnityEngine;
using System.Collections;

public class PointsControl : MonoBehaviour {

	[SerializeField] private GameObject pointPrefab;
	[SerializeField] private int numX;
	[SerializeField] private int numY;
	[SerializeField] private float rotAngle = 0.0f;

	private GameObject[] points;
	private float timer = 0.0f;


	private float rhythm;
	public float Rhythm {
		get { return rhythm;} 
		set { rhythm = value;}
	}

	// Use this for initialization
	void Start () {
		CreatePoints ();
		this.transform.Rotate (Vector3.forward, rotAngle);
	}

	private void CreatePoints () {
		int numPoints = numX * numY;
		points = new GameObject[numPoints];
		for (int i = 0; i < numX; i++) {
			for (int j = 0; j < numY; j++) {
				float offset = (j % 2 == 0) ? 1.0f : 0.0f;
				points [i*numY + j] = Instantiate (pointPrefab, new Vector3 ((i-numX/2.0f) * 2.0f  + offset, (j-numY/2.0f) * 2.0f ), Quaternion.identity, this.transform) as GameObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer = Time.unscaledTime;
		for (int i = 0; i < numX; i++) {
			for (int j = 0; j < numY; j++) {
				GameObject point = points [i * numY + j];
				float scale = ( Mathf.Sin (point.transform.localPosition.x + timer * rhythm) +1 )* 0.5f + ( Mathf.Sin (point.transform.localPosition.y + timer * rhythm) +1 )* 0.5f;
				if ( i == 1 && j == 1) Debug.Log (scale);
				//point.transform.localScale.Set (scale, scale, 1);
				point.transform.localScale = new Vector3 (scale, scale, 1);
				//= point.transform.localScale.y = scale;
			}
		}
	}
}
