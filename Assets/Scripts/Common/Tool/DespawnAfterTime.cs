using UnityEngine;

namespace CaptureTheFlag.Common.Tool {
	public class DespawnAfterTime : MonoBehaviour {
		public float timeToDestroy = 1.2f;
		void Start () {
			Destroy( gameObject, timeToDestroy );
		}
	}
}