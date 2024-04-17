using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
            GetComponent<Rigidbody>().velocity += moveDirection;

        if (Input.GetKey(keyTwo))
            GetComponent<Rigidbody>().velocity -= moveDirection;
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetKey(KeyCode.Q))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            if (SceneManager.sceneCountInBuildSettings-1 > SceneManager.GetActiveScene().buildIndex)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = true;
            }
        }
    }
}
