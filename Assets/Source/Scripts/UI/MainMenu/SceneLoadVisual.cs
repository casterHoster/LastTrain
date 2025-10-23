using UnityEngine;
using UnityEngine.UI;

namespace LastTrain.UI.MainMenu
{
    public class SceneLoadVisual : MonoBehaviour
    {
        [SerializeField] private GameObject _loadScreen;
        [SerializeField] private Slider _loadBar;

        private void Start()
        {
            _loadBar.value = 0;
            _loadScreen.SetActive(false);
        }

        public void OpenLoadScreen()
        {
            _loadScreen.SetActive(true);
            _loadBar.value = 0;
        }

        public void UpdateLoadbar(float value)
        {
            _loadBar.value = value;
        }
    }
}