using System;

namespace Player {
    public class Health : IStat<int> {

        public Action<int> OnChangeEvent { get; set; }
        public Action OnZero { get; set; }
        
        public int MaxValue { get; private set; }
        
        private int value;
        public int Value {
            get {
                return this.value;
            }
            private set {
                this.value = value;
                OnChangeEvent?.Invoke( this.value );
                if ( this.value <= 0 ) {
                    OnZero?.Invoke(  );
                }
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