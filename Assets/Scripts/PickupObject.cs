using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.ObjectCollected();

            Destroy(gameObject);
        }
    }
}