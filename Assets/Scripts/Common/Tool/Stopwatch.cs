using System;

namespace Common {
    public class Stopwatch {
        public double ElapsedSeconds { get; private set; }
        
        public Action<double> TickCallback;
        public Action<double, bool> OnCountingFinish;
        
        private bool isStopped = true;

        public Stopwatch( bool stopped = false ) {
            this.isStopped = stopped;
        } 
        
        public Stopwatch( Action<double> tickCallback, bool stopped = false ) : this( stopped ) {
            TickCallback += tickCallback;
        } 
        
        public void FinishCounting( bool won ) {
            Stop(  );
            OnCountingFinish?.Invoke( ElapsedSeconds, won );
        }
        
        public void Tick(float deltaTime) {
            if ( isStopped ) {
                return;
            }
            ElapsedSeconds += deltaTime;
            TickCallback.Invoke( ElapsedSeconds );
        }

        public void Stop() {
            isStopped = true;
        }
        
        public void Continue() {
            isStopped = false;
        }
        
    }
}