using System;
using System.Collections.Generic;
using Common;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityTemplateProjects.ScriptableObjects {
    
    [CreateAssetMenu(fileName = "EventSO", menuName = "ScriptableObjects/EventSO", order = 1)]
    public class GameEvent : ScriptableObject {
        [SerializeField] private List<GameEventListener> listeners = new List<GameEventListener>( );

        public void Raise( ) {
            for ( int i = listeners.Count - 1; i >= 0; i-- ) {
                listeners[ i ].OnEventRaised( );
            }
        }

        public void RegisterListener( GameEventListener listener ) {
            listeners.Add( listener );
        }

        public void RemoveListener( GameEventListener listener ) {
            listeners.Remove( listener );
        }
    }
}