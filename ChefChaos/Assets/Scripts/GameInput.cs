using UnityEngine;

public class GameInput : MonoBehaviour {
    private PlayerInputActions playerInputActions;

    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        
        return inputVector.normalized;
    }

    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }
}
