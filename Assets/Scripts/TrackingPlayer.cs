using UnityEngine;
using UnityEngine.AI;

public class TrackingPlayer : MonoBehaviour
{
    public Transform Target;
    public NavMeshAgent Enemy;

    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        Enemy.SetDestination(Target.position);
    }
    void Update()
    {
        Enemy.SetDestination(Target.position);
    }
}
