using UnityEngine.Events;

namespace Player {
    public interface IStat<T> {
        public T Value { get; }
        public T MaxValue { get; }
        public void Decrease( );
        public void Increase( );
        public void Set( T value );
        public UnityEvent<T> OnChangeEvent { get; set; }

    }
}