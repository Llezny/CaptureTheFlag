namespace CaptureTheFlag.Collectible {
    public class CollectibleFlagBehaviour : CollectibleBehaviour {
        public override void Collect( ) {
            Hide( );
            base.Collect(  );
        }
    
        private void Hide( ) {
            this.gameObject.SetActive( false );
        }
    }
}
