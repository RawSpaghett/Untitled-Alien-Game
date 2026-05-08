using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{

    PlayerBaseState currentState;

    PlayerCaughtState CaughtState = new PlayerCaughtState();
    PlayerCrouchingState CrouchingState = new PlayerCrouchingState();
    PlayerNormalState NormalState = new PlayerNormalState();


    void Start()
    {
        // starting state for SM
        currentState = NormalState;

        // "this" is a reference to the context or the instance of the PlayerStateMachine
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
