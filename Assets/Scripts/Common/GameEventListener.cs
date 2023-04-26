using System;
using UnityEngine;
using UnityEngine.Events;
using UnityTemplateProjects.ScriptableObjects;

namespace Common {
    public class GameEventListener : MonoBehaviour {
        public GameEvent gameEvent;
        public UnityEvent Response;

        private void OnEnable( ) {
            gameEvent.RegisterListener( this );
        }
        
        private void OnDisable( ) {
            gameEvent.RemoveListener( this );
        }

        public void OnEventRaised( ) {
            Response?.Invoke(  );
        }
    }
}