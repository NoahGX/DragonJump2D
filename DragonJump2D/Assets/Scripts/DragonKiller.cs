using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 6 || y < 6)
        {
            SceneManager.LoadScene(0);
        }
    }
}
