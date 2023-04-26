﻿using System;

namespace Common {
    public class Stopwatch {
        public double ElapsedSeconds { get; private set; }
        public Action<double> TickCallback;
        private bool isStopped = true;

        public Stopwatch( bool stopped = false ) {
            this.isStopped = stopped;
        } 
        
        public Stopwatch( Action<double> tickCallback, bool stopped = false ) : this( stopped ) {
            TickCallback += tickCallback;
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