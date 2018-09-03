using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KPad.Networking
{
    [AddComponentMenu("KPad/Networking/NetworkPlayer")]
    [DisallowMultipleComponent]
    public class NetworkPlayer : NetworkBehaviour
    {
        [SerializeField] private string m_playerName;

        public string playerName { get { return m_playerName; } }
    }
}