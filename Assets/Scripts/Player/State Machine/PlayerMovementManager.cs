using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    PlayerBaseState currentState;

    PlayerBaseState idleState = new PlayerIdleState();
    PlayerBaseState walkingState = new PlayerWalkingState();
    PlayerBaseState crouchingState = new PlayerCrouchingState();

    // I have to migrate the stuff from the movement controller here

    void Start() 
    {
    	currentState = idleState;

    	currentState.EnterState(this);
    }

    void Update()
    {

    }

    void SwitchState(PlayerBaseState state) 
    {
    	currentState = state;

    	currentState.EnterState(this);
    }
}
 