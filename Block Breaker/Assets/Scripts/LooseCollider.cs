using UnityEngine;

public class LooseCollider : MonoBehaviour
{
    private LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Loose Sceen");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collider");
    }
}
