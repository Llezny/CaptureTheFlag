using UnityEngine;

public class DespawnAfterTime : MonoBehaviour {
	[Tooltip("Time to destroy")]
	public float timeToDestroy = 1.2f;
	void Start () {
		Destroy( gameObject, timeToDestroy );
	}

}