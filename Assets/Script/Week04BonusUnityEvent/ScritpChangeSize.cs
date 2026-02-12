using UnityEngine;

public class ScritpChangeSize : MonoBehaviour
{
    private void OnEnable()
    {
        ScriptEventManager.IncreaseSizeEvent += IncreaseSize;
        ScriptEventManager.ReduceSizeEvent += ReduceSize;
    }

    private void OnDisable()
    {
        ScriptEventManager.IncreaseSizeEvent -= IncreaseSize;
        ScriptEventManager.ReduceSizeEvent -= ReduceSize;
    }

    void IncreaseSize()
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.5f,
                                           transform.localScale.y * 1.5f,
                                           transform.localScale.z * 1.5f);
    }

    void ReduceSize()
    {
        transform.localScale = new Vector3(transform.localScale.x * 0.8f,
                                           transform.localScale.y * 0.8f,
                                           transform.localScale.z * 0.8f);
    }
}
