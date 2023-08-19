using UnityEngine;

public abstract class EnemyBaseState
{
    /// <summary>
    /// this mehtod is called whenever this state is entered
    /// </summary>
    public abstract void enterState();
    public abstract void updateState();
}
