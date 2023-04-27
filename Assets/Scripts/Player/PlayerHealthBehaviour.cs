using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Player {
    public class PlayerHealthBehaviour : MonoBehaviour {

        [ SerializeField ] private int maxHealth = 3;
        public Action OnHit { get; set; }
        public Action<int> OnChange { get => health.OnChangeEvent; set => health.OnChangeEvent = value; }
        public Action OnDie { get => health.OnZero; set => health.OnZero = value; }
        
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

        public void GetHit( ) {
            health.Decrease(  );
            OnHit?.Invoke(  );
        }
    }
}
       