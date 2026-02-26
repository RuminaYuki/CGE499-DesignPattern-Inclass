using UnityEngine;

public class ClientObserver : MonoBehaviour
{
    private ObBikeController _bikeController;
    private void Start()
    {
        _bikeController = (ObBikeController)FindObjectOfType(typeof(ObBikeController));
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Damage Bike"))
            if (_bikeController)
                _bikeController.TakeDamage(15.0f);

        if (GUILayout.Button("Toggle Turbo"))
            if (_bikeController)
                _bikeController.ToggleTurbo();
    }
}
