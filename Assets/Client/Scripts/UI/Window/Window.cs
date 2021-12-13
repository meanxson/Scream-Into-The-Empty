using UnityEngine;

namespace Client.Scripts.UI.Window
{
    public abstract class Window : MonoBehaviour
    {
        public void Open()
        {
            MainMenu.MainMenu.Instance.CloseAllButtons();
            gameObject.SetActive(true);
        }

        public void Close() => gameObject.SetActive(false);
    }
}