using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KPad.Networking
{
    public class NetworkSpawnManager : MonoBehaviour
    {
        [SerializeField] private List<GameObject> spawnObjects = new List<GameObject>();

        private void Awake()
        {
            foreach (GameObject gameObject in spawnObjects)
            {
                if (gameObject == null) continue;
                UnityEngine.Networking.ClientScene.RegisterPrefab(gameObject);
            }
        }
    }
}