using UnityEngine;

public class KillPlayerHitbox : MonoBehaviour

{
    void OnTriggerEnter2D(Collider2D col)
    {
        // Check if the object has the InstantDeathRespawn component
        InstantDeathRespawn respawn = col.GetComponent<InstantDeathRespawn>();

        if (respawn != null)
        {
            // Trigger respawn on the player
            respawn.SendMessage("Respawn", SendMessageOptions.DontRequireReceiver);
        }
        // If the script is missing: ignore the object completely
    }
}