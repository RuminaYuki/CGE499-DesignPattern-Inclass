using UnityEngine;

public class BikeController : Subject
{
    public bool IsturboOn
    {
        get; private set;
    }

    public float CurrentHealth
    {
        get
        {
            return health;
        }
    }

    private bool _isEngineOn;
    private HUDController _hudController;
    private CameraController _cameraController;

    [SerializeField]
    private float health = 100.0f;

    void Awake()
    {
        _hudController = gameObject.AddComponent<HUDController>();
        _cameraController = (CameraController)FindObjectOfType(typeof(CameraController));
    }

    void Start()
    {
        StartEngine();
    }
}
