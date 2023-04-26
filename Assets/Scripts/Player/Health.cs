﻿using UnityEngine.Events;

namespace Player {
    public class Health : IStat<int> {

        public Health( ) {
            OnChangeEvent = new UnityEvent<int>( );
        }
        
        public UnityEvent<int> OnChangeEvent { get; set; }
        public int MaxValue { get; private set; }
        
        private int value;
        public int Value {
            get {
                return this.value;
            }
            private set {
                this.value = value;
                OnChangeEvent?.Invoke( this.value );
            }
        }

        public void Decrease( ) {
            Value--;
        }

        public void Increase( ) {
            Value++;
        }

        public void Set( int value ) {
            Value = value;
        }


    }
}