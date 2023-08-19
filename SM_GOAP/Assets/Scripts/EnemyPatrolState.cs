using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrolState : EnemyBaseState
{
    Transform enemy;
    NavMeshAgent agent;
    Transform[] waypoints;
    int nextWaypointIndx=0;
    Transform nextWaypoint;
    public override void enterState(EnemyStateManager manager)
    {
        Debug.Log("entered patrolling state");
        enemy = manager.Enemy;
        waypoints = Waypoints.waypointsArr;
        nextWaypoint = waypoints[nextWaypointIndx];
        agent = manager.GetComponent<NavMeshAgent>();
    }

    public override void updateState(EnemyStateManager manager)
    {
        Debug.Log(Vector3.Distance(enemy.transform.position, nextWaypoint.transform.position));
        // if reached next waypoint update new destination
        if (Vector3.Distance(manager.transform.position, nextWaypoint.transform.position) <= 0.3)
        {
            //update next index. reset to 0 when done
            nextWaypointIndx = nextWaypointIndx == waypoints.Length ? 0 : nextWaypointIndx + 1;
            nextWaypoint = waypoints[nextWaypointIndx];
            Debug.Log($"goign to new waypoint index = {nextWaypointIndx}");
            
        }
        agent.destination = nextWaypoint.position;

    }
}
