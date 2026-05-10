using UnityEngine;

public abstract class PlayerBaseState
{
	public abstract void EnterState(PlayerMovementManager movementManager);

    public abstract void UpdateState(PlayerMovementManager movementManager);

    public abstract void ExitState(PlayerMovementManager movementManager);

    public abstract void CheckSwitchState(PlayerMovementManager movementManager);
}
