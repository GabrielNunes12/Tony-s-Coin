using System;
using UnityEngine;

namespace CheckPoint
{
    public class RespawnerEntity : MonoBehaviour
    {
        private PlayerHealth _playerHealth;
        [SerializeField] private GameObject _playerGameObject;
        private Vector3 _lastUpdatedPosition;

        public Vector3 GetLastUpdatedPosition
        {
            get
            {
                return _lastUpdatedPosition;
            }
            set
            {
                _lastUpdatedPosition = value;
            }
        }
        private void Start()
        {
            _playerGameObject = GameObject.FindWithTag("Player").gameObject;
        }

        private void Update()
        {
            
        }
    }
}