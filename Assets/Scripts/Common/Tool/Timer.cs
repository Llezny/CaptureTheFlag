using System;

namespace CaptureTheFlag.Common.Tool {
    public class Timer {
        public float RemainingSeconds { get; private set; }
        public Action OnTimerEnd;

        public Timer(float duration) {
            RemainingSeconds = duration;
        } 
        
        public Timer(float duration, Action timerCallback ) : this( duration ) {
            OnTimerEnd += timerCallback;
        } 
        
        public void Tick(float deltaTime) {
            if ( RemainingSeconds == 0f ) {
                return; 
                
            }
            RemainingSeconds -= deltaTime;
            CheckForTimerEnd();
        }

        private void CheckForTimerEnd() {
            if ( RemainingSeconds > 0f ) {
                return;
            }
            RemainingSeconds = 0f;
            OnTimerEnd?.Invoke();
        }
    }
}