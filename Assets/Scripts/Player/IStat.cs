using System;

namespace Player {
    public interface IStat<T> {
        public T Value { get; }
        public T MaxValue { get; }
        public void Decrease( );
        public void Increase( );
        public void Set( T value );
        public Action<T> OnChangeEvent { get; set; }
        public Action OnZero { get; set; }

    }
}