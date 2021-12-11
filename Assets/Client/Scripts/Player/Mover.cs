using System;
using UnityEngine;

namespace Client.Scripts.Player
{
   public class Mover : MonoBehaviour
   {
      [SerializeField] private float _speed;

      private CharacterController _characterController;
      private void Awake()
      {
         _characterController = GetComponent<CharacterController>();
      }

      private void Update()
      {
         var horizontal = Input.GetAxis("Horizontal");
         var vertical = Input.GetAxis("Vertical");
         var nextPosition = transform.right * horizontal + transform.forward * vertical;
         _characterController.Move(nextPosition * _speed * Time.deltaTime);
      }
   }
}
