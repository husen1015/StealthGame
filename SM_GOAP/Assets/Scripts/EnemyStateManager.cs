using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    public Transform Enemy;
    EnemyBaseState currentState;
    EnemyPatrolState patrolState = new EnemyPatrolState();
    EnemyInvestigateState investigateState= new EnemyInvestigateState();
    EnemyAlertState alertState= new EnemyAlertState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = patrolState;
        currentState.enterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.updateState(this);
    }
    void SwitchState(EnemyBaseState state)
    {
        currentState = state;
        currentState.enterState(this);
    }
}
