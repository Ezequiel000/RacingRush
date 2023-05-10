using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
       
        public string SceneName;

        public void LoadTargetScene() 
        {
            SceneManager.LoadSceneAsync(SceneName);
        }
    }
}
