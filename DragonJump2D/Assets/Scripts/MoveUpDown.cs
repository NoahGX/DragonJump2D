using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    private float HeightVariance;

    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) *
            Time.deltaTime * HeightVariance;
    }
}
