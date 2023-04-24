using System.Collections;
using Lean.Pool;
using UnityEngine;

public class DespawnAfterTime : MonoBehaviour {
	[Tooltip("Time to destroy")]
	public float timeToDestroy = 0.8f;
	void Start () {
		Destroy( gameObject, timeToDestroy );
	}

}
