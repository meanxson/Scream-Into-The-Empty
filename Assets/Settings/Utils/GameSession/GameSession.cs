using UnityEngine;

namespace Utils.GameSession
{
   public class GameSession : MonoBehaviour
   {
      [SerializeField] private PlayerModel _playerModel;
      public PlayerModel PlayerModel => _playerModel;

      private void Start()
      {
         if (gameObject != null) DontDestroyOnLoad(this);
         else
            DestroyImmediate(gameObject);
      }
   }
}
