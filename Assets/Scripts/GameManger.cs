using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int score = 0;
    private int lives = 3;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("⭐ Puntuación actual: " + score);
    }

    public void LoseLife()
    {
        lives--;
        Debug.Log("💔 Vidas restantes: " + lives);

        if (lives <= 0)
        {
            Debug.Log("💀 Game Over");
        }
    }

    public int GetScore()
    {
        return score;
    }

    public int GetLives()
    {
        return lives;
    }
}