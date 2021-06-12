using UnityEngine;
using UnityEngine.AI;

namespace PhantomSyntax.Scripts.Navigation {
    public class PlayerNavigation : MonoBehaviour {
        [Header("Player Navigation Settings")]
        [SerializeField] private NavMeshAgent _navMeshAgent;
        [SerializeField] private GameObject playerEnd;
        [SerializeField] private float _playerMoveSpeed = 2.0f;

        private void Start() {
            if (!playerEnd) {
                playerEnd = GameObject.FindWithTag("PlayerEnd");
            }

            if (!_navMeshAgent) {
                _navMeshAgent = GetComponent<NavMeshAgent>();
            }
            // Setup the NavMeshAgent properties
            _navMeshAgent.destination = playerEnd.transform.position;
            _navMeshAgent.speed = _playerMoveSpeed;
        }
    }
}
