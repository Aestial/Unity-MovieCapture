using UnityEngine;
using System.Collections;

public class RandomBoxPosition : MonoBehaviour {

	[SerializeField] private Vector3 boxSize;
	[SerializeField] private float updateTime;
	[SerializeField] private float startTime;

	private Transform left;
	private Transform right;
	private Vector3 leftOriginal;
	private Vector3 rightOriginal;

	// Use this for initialization
	void Start () {
		left = transform.GetChild (0);
		right = transform.GetChild (1);
		leftOriginal = left.localPosition;
		rightOriginal = right.localPosition;
		InvokeRepeating ("ChangePosition", startTime, updateTime);
	}

	private void ChangePosition () {
		var rv = new Vector3(Random.value, Random.value, Random.value);
		left.localPosition = Vector3.Scale (rv - Vector3.one * 0.5f, boxSize) + leftOriginal;
		right.localPosition = Vector3.Scale (rv - Vector3.one * 0.5f, boxSize) + rightOriginal;
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(0, 1, 1, 0.5f);
		Gizmos.matrix = transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, boxSize);
	}
}
