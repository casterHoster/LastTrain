using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace LastTrain.UI.MainMenu
{
    public static class SceneLoader
    {
        public static async Task Load(string sceneName, SceneLoadVisual loadVisual)
        {
            var loading = SceneManager.LoadSceneAsync(sceneName);

            while (!loading.isDone)
            {
                loadVisual.UpdateLoadbar(loading.progress);
                await Task.Yield();
            }
        }
    }
}
