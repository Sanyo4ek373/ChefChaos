using UnityEngine;

public class GameInput : MonoBehaviour {
    private PlayerInputActions _playerInputActions;

    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = _playerInputActions.Player.Move.ReadValue<Vector2>();
        
        return inputVector.normalized;
    }

    private void Awake() {
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Player.Enable();
    }
}
