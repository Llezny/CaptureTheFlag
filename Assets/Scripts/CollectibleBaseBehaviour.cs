using System;
using UnityEngine;

namespace DefaultNamespace {
    public class CollectibleBaseBehaviour : CollectibleBehaviour {

        public override void Collect( ) {
            Debug.Log( "Collecting flag" );
            base.Collect(  );
        }
    }
}