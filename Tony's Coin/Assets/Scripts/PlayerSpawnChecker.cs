using UnityEngine;

namespace CheckPoint
{
    public class PlayerSpawnChecker : MonoBehaviour
    {
        private bool isTouchedCheckpoint;

        public bool GetIsTouchedCheckPoint
        { get { return this.isTouchedCheckpoint; } set {this.isTouchedCheckpoint = value;} }
        // Start is called before the first frame update
        void Start()
        {
            isTouchedCheckpoint = false;
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Checkpoint")
            {
                isTouchedCheckpoint = true;
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.tag == "Checkpoint")
            {
                isTouchedCheckpoint = false;
            }
        }
    }

}