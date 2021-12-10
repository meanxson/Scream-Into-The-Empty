using Client.Scripts.Effects;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Scripts.UI.Window.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        public static MainMenu Instance { get; private set; }
        
        [SerializeField] private Window[] _windows;
        [SerializeField] private Transition _transition;

        public Window PreviousWindow { get; private set; }

        private Window _currentWindow;

        private void Awake() 
        {
            if (Instance == null) 
                Instance = this;

            _currentWindow = _windows[0];
            PreviousWindow = _currentWindow;
        }

        private void Start()
        {
            _transition.FadeOut();
            CloseAllButtons();
            _currentWindow.Open();
        }

        public void CloseAllButtons()
        {
            foreach (var window in _windows) window.Close();
        }

        [Button]
        private void InitWindows()
        {
            _windows = GetComponentsInChildren<Window>(true);
            _transition = GetComponentInChildren<Transition>(true);
        }
    }
}