using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovementBehaviour : MonoBehaviour {
    
    [ Header( "References" ) ]
    [ SerializeField ] private Transform cameraTransform;
    [ SerializeField ] private Transform playersBody;

    [ Header( "Parameters" ) ] 
    [ SerializeField ] private float mouseSensitivity;
    [ SerializeField ] private bool showCursor;

    private float xRotation;

    private void OnEnable( ) {
        InputReceiverBehaviour.OnLookPressed += HandleMouseMovement;
        Cursor.visible = showCursor;
    }
    
    private void OnDisable( ) {
        InputReceiverBehaviour.OnLookPressed -= HandleMouseMovement;
        Cursor.visible = true;
    }
    
    private void HandleMouseMovement( InputValue inputValue ) {
        var mouseMovement = inputValue.Get<Vector2>( ) * Time.deltaTime * mouseSensitivity;
        MoveCameraHorizontally( mouseMovement.x );
        MoveCameraVertically( mouseMovement.y );
    }

    private void MoveCameraHorizontally( float mouseMovementX ) {
        playersBody.Rotate( Vector3.up * mouseMovementX );
    }
    
    private void MoveCameraVertically( float mouseMovementY ) {
        xRotation -= mouseMovementY;
        xRotation = Mathf.Clamp( xRotation, -90, 90 );
        cameraTransform.localRotation = Quaternion.Euler( xRotation, 0, 0 );
    }
}