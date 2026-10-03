using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text uiText;

    public int totalObjects = 3;

    private int objectsCollected = 0;
    private bool hasWon = false;

    void Start()
    {
        uiText.text = "Collect all 3 objects and reach the final platform to win!";
    }

    public void ObjectCollected()
    {
        objectsCollected++;

        if (objectsCollected < totalObjects)
        {
            uiText.text = "Objects Collected: " + objectsCollected + " / " + totalObjects;
        }
        else
        {
            uiText.text = "All objects collected! Find the final platform.";
        }
    }

    public void ReachFinalPlatform()
    {
        if (objectsCollected >= totalObjects && !hasWon)
        {
            hasWon = true;

            uiText.text = "YOU WIN!";
        }
    }
}