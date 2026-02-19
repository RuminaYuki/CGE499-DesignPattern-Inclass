using UnityEngine;

public class ClientObjectPool : MonoBehaviour
{
    private DroneObjectPool _pool;
    void Start()
    {
        _pool = gameObject.AddComponent<DroneObjectPool>();
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Spawn Drones"))
        {
            _pool.Spawn();
        }
    }
}
