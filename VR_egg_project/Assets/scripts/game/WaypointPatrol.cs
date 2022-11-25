using UnityEngine;
using UnityEngine.AI;

// NavMeshAgentコンポーネントがアタッチされていない場合アタッチ
[RequireComponent(typeof(NavMeshAgent))]
public class WaypointPatrol : MonoBehaviour
{
    [SerializeField]
    [Tooltip("巡回する地点の配列")]
    private Transform[] waypoints;

    // NavMeshAgentコンポーネントを入れる変数
    private NavMeshAgent navMeshAgent;
    // 現在の目的地
    private int currentWaypointIndex;

    // Start is called before the first frame update
    void Start()
    {
        // navMeshAgent変数にNavMeshAgentコンポーネントを入れる
        navMeshAgent = GetComponent<NavMeshAgent>();
        // 最初の目的地を入れる
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        // 目的地点までの距離(remainingDistance)が目的地の手前までの距離(stoppingDistance)以下になったら
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            // 目的地の番号を１更新（右辺を剰余演算子にすることで目的地をループさせれる）
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            // 目的地を次の場所に設定
            navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }
}