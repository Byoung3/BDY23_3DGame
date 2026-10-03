using UnityEngine;

public class FinalPlatform : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // Check that the player touched the platform
        if (other.CompareTag("Player"))
        {
            gameManager.ReachFinalPlatform();
        }
    }
}