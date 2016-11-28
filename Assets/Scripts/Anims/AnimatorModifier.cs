using UnityEngine;
using System.Collections;

public class AnimatorModifier : MonoBehaviour {

	[Range(0, 0.75f)]
	[SerializeField] private float animatorSpeed;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		animator.speed = animatorSpeed;
	}

	void OnValidate () {
		Start ();
	}
}
