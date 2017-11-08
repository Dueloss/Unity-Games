using UnityEngine;

public class LooseCollider : MonoBehaviour
{
    public LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        levelManager.LoadLevel("Win Sceen");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collider");
    }
}
