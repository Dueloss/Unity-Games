using UnityEngine;

public class Brick : MonoBehaviour
{
    public AudioClip Crack;
    private LevelManager levelManager;
    public Sprite[] HitSprites;
    private int timesHit;
    public static int breakableCount = 0;
    private bool isBreakable;
    // Use this for initialization
    void Start()
    {
        isBreakable = (tag == "Breakable");
        levelManager = FindObjectOfType<LevelManager>();
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }

        timesHit = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(Crack, transform.position);
        if (isBreakable)
        {
            handleHits();
        }
    }

    private void handleHits()
    {
        timesHit++;
        if (timesHit >= HitSprites.Length + 1)
        {
            breakableCount--;
            levelManager.BrickDestroyd();
            Destroy(gameObject);
        }
        else
        {
            loadSprites();
        }
    }

    private void loadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (HitSprites[spriteIndex])
        {
            GetComponent<SpriteRenderer>().sprite = HitSprites[spriteIndex];
        }
    }
    private void simulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
