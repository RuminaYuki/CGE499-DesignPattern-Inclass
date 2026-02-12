using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;

    private bool _isReplaying;
    private bool _isRecording;

    private BikeController _bikeController;

    private Command _buttonA;
    private Command _buttonD;
    private Command _buttonW;

    void Start()
    {
        // Add Invoker component
        _invoker = gameObject.AddComponent<Invoker>();

        // Find BikeController in scene
        _bikeController = FindObjectOfType<BikeController>();

        // Create Commands
        _buttonA = new TurnLeft(_bikeController);
        _buttonD = new TurnRight(_bikeController);
        _buttonW = new ToggleTurbo(_bikeController);
    }

    void Update()
    {
        // Only allow input if not replaying
        if (!_isReplaying)
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                _invoker.ExecuteCommand(_buttonA);
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                _invoker.ExecuteCommand(_buttonD);
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                _invoker.ExecuteCommand(_buttonW);
            }
        }
    }

    void OnGUI()
    {
        if (GUILayout.Button("Start Recording"))
        {
            _bikeController.ResetPosition();

            _isReplaying = false;
            _isRecording = true;

            _invoker.Record();
        }

        if (GUILayout.Button("Stop Recording"))
        {
            _bikeController.ResetPosition();

            _isRecording = false;
        }

        if (!_isRecording)
        {
            if (GUILayout.Button("Start Replay"))
            {
                _bikeController.ResetPosition();

                _isRecording = false;
                _isReplaying = true;

                _invoker.Replay();
            }
        }
    }
}