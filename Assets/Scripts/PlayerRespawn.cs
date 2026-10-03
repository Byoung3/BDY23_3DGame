using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float fallHeight = -30f;
    private CharacterController characterController;
    public Transform respawnPoint;

    void Start()
    { // Get the Character Controller on the player
      characterController = GetComponent<CharacterController>();

    }
        void Update()
    {
        // Check if the player has fallen below the fall height
        if (transform.position.y < fallHeight)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        if (respawnPoint != null)
        {
            // Disable Character Controller before teleporting
            characterController.enabled = false;

            transform.position = respawnPoint.position;

            // Re-enable Character Controller
            characterController.enabled = true;
        }
    }
}