using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 5;

    //Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed);
    }
}
