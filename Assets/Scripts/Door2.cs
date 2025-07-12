using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    [SerializeField] private CameraController cam;

    private void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
