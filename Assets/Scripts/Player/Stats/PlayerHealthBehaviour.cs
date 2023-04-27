using System;
using Common;
using UnityEngine;

namespace Player {
    public class PlayerHealthBehaviour : MonoBehaviour {

        [ SerializeField ] private int maxHealth = 3;
        [ SerializeField ] private float damageCooldown = 1f;
        public Action OnHit { get; set; }
        public Action<int> OnChange { get => health.OnChangeEvent; set => health.OnChangeEvent = value; }
        public Action OnDie { get => health.OnZero; set => health.OnZero = value; }
        
        private Timer cooldownTimer;
        private bool isInCooldown = false;
        private readonly IStat<int> health = new Health();

        private void OnEnable( ) {
            OnDie += GameplayManager.LoseGame;
        }

        private void OnDisable( ) {
            OnDie -= GameplayManager.LoseGame;
        }

        private void Start( ) {
            health.Set( maxHealth );
        }

        private void Update( ) {
            cooldownTimer?.Tick( Time.deltaTime );
        }

        public void GetHit( ) {
            if ( isInCooldown ) {
                return;
            }
            health.Decrease(  );
            OnHit?.Invoke(  );
            SetupTimer(  );
        }
        
        private void SetupTimer( ) {
            isInCooldown = true;
            cooldownTimer = new Timer( damageCooldown, ( ) => isInCooldown = false );
        }
    }
}
       