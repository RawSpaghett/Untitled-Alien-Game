using UnityEngine;

public class EnemyIdleState : EnemyState //still
{
    public EnemyIdleState(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
        isPassive = true;
    }
    
    public override void EnterState()
    {
        base.EnterState();
        enemy.rb.linearVelocity = Vector3.zero;
    }
    public override void ExitState()
    {
        base.ExitState();
    }
    public override void FrameUpdate()
    {
        base.FrameUpdate();
    }
}
