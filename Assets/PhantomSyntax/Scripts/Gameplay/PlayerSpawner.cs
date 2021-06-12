using UnityEngine;

namespace PhantomSyntax.Scripts.Gameplay {
    public class PlayerSpawner : MonoBehaviour {
        [Header("Player Spawning Settings")]
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private GameObject playerStart;

        private void Start() {
            if (!playerStart) {
                playerStart = GameObject.FindWithTag("PlayerStart");
            }
            
            Instantiate(playerPrefab, playerStart.transform.position, playerStart.transform.rotation);
        }
    }
}
