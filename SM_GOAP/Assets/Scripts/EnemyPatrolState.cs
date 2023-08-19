using UnityEngine;

public class EnemyPatrolState : EnemyBaseState
{
    public override void enterState()
    {
        Debug.Log("entered patrolling state");
    }

    public override void updateState()
    {
        throw new System.NotImplementedException();
    }
}
