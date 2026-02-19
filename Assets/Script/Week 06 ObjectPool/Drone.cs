using UnityEngine;
using System.Collections;
using UnityEngine.Pool;

public class Drone : MonoBehaviour
{
    public IObjectPool<Drone> Pool {  get; set; }
    public float _currentHeath;

    [SerializeField] private float maxHealth = 100.0f;
    [SerializeField] private float timeToselfDestruct = 3.0f;

    private void Start()
    {
        _currentHeath = maxHealth;
    }

    private void OnEnable()
    {
        AttackPlayer();
        StartCoroutine(SelfDestruct());
    }

    private void OnDisable()
    {
        ResetDrone();
    }

    public void AttackPlayer()
    {
        Debug.Log("Attack Player");
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeToselfDestruct);
        TakeDamage(maxHealth);
    }

    private void ResetDrone()
    {
        _currentHeath = maxHealth;
    }

    private void ReturnToPool()
    {
        Pool.Release(this);
    }

    public void TakeDamage(float amout)
    {
        _currentHeath -= amout;
        if( _currentHeath <= 0.0f)
        {
            ReturnToPool();
        }
    }
}
