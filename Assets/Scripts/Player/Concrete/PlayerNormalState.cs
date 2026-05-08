using UnityEngine;

public class PlayerNormalState : PlayerBaseState
{
    public override void EnterState(PlayerStateMachine player)
    {
        Debug.Log("Hello from the normal state!");
    }

    public override void UpdateState(PlayerStateMachine player)
    {

    }

    public override void OnCollisionEnter(PlayerStateMachine player)
    {

    }
}
