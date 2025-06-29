using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameObject winPanel;

    void Start()
    {
        winPanel = GameObject.FindWithTag("WinPanel"); // Tìm bằng tag
        if (winPanel == null)
        {
            Debug.LogError("Win Panel not found with tag 'WinPanel'");
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            if (winPanel != null)
            {
                winPanel.SetActive(true); // Hiển thị panel win
            }
        }
    }
}