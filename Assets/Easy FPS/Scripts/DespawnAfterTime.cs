using UnityEngine;

namespace Easy_FPS.Scripts {
	public class DespawnAfterTime : MonoBehaviour {
		[Tooltip("Time to destroy")]
		public float timeToDestroy = 0.8f;
		void Start () {
			Destroy( gameObject, timeToDestroy );
		}

	}
}
