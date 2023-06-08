using UnityEngine;
using UnityEngine.Events;

namespace com.NeatWolf.SnapshotSignal
{
    [System.Serializable]
    public class SnapshotSignalEvent : UnityEvent<float> { }

    public class SnapshotSignalReceiver : MonoBehaviour
    {
        public SnapshotSignalEvent snapshotSignalEvent;
    }
}