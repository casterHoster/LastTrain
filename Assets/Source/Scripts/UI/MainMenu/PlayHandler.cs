using LastTrain.Inventory;
using LastTrain.Level;
using UnityEngine;
using UnityEngine.UI;

namespace LastTrain.UI.MainMenu
{
    public class PlayHandler : MonoBehaviour
    {
        [SerializeField] private LevelsHandler _levelsHandler;
        [SerializeField] private PlayerInventoryHandler _playerInventoryHandler;
        [SerializeField] private string _gameplayScene;
        [SerializeField] private Button _playButton;
        [SerializeField] private SceneLoadVisual _sceneLoadVisual;

        private void Awake()
        {
            _playButton.onClick.AddListener(StartPlay);
        }

        private async void StartPlay()
        {
            if (_levelsHandler.IsChosed && _playerInventoryHandler.TryGiveInventoryWeaponFromSlots())
            {
                _sceneLoadVisual.OpenLoadScreen();
               await SceneLoader.Load(_gameplayScene, _sceneLoadVisual);
            }
        }
    }
}
