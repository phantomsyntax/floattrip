using UnityEngine;
using UnityEngine.SceneManagement;

namespace PhantomSyntax.Scripts.UI {
    public class UserInterfaceManager : MonoBehaviour {
        // [Header("User Interface Settings")]

        public void HandleLoadSceneDelayed() {
            SceneManager.LoadScene("04_ButtercupCreek");
        }
    }
}
