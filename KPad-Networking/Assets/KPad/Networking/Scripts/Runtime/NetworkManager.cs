using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KPad.Networking
{
    public class NetworkManager : UnityEngine.Networking.NetworkManager
    {
        private NetworkManager m_singleton;

        public new NetworkManager singleton { get { return m_singleton; } }

        private void OnEnable()
        {
            m_singleton = UnityEngine.Networking.NetworkManager.singleton as NetworkManager;
        }
    }
}