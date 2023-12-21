using UnityEngine;

namespace CheckPoint
{
    
    public class Checkpoint : MonoBehaviour
    {
        private Transform _playerTransform;
        private PlayerSpawnChecker _playerSpawnChecker;
        private RespawnerEntity _respawner;
        private void Start()
        {
            _playerTransform = GameObject.FindWithTag("Player")
                .GetComponent<Transform>();
            _playerSpawnChecker = GameObject.FindWithTag("Player")
                .GetComponent<PlayerSpawnChecker>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Player" && _playerSpawnChecker.GetIsTouchedCheckPoint)
            {
                //pegando a posição do checkpoint atual e alterando do player
                _playerTransform.transform.position = gameObject.transform.position;
                _respawner.GetLastUpdatedPosition = gameObject.transform.position;
            }
        }
    }
}
