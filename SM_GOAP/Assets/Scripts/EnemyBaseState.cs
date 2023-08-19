using UnityEngine;

public abstract class EnemyBaseState
{
    /// <summary>
    /// this mehtod is called whenever this state is entered
    /// </summary>
    public abstract void enterState(EnemyStateManager manager);
    public abstract void updateState(EnemyStateManager manager);
}
