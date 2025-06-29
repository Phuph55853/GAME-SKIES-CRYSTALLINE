using UnityEngine;

public class RandomMapGenerator : MonoBehaviour
{
    public int width = 7;
    public int height = 7;

    public GameObject floorPrefab;
    public GameObject goalPrefab;
    public GameObject playerPrefab;

    private bool goalPlaced = false;

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                Vector3 pos = new Vector3(x, 0, z);
                Instantiate(floorPrefab, pos, Quaternion.identity);

                if (x == 0 && z == 0)
                {
                    // Spawn Player
                    Instantiate(playerPrefab, pos + Vector3.up * 0.5f, Quaternion.identity);
                }
                else if (!goalPlaced && Random.value > 0.95f)
                {
                    // Spawn Goal
                    Instantiate(goalPrefab, pos + Vector3.up * 0.1f, Quaternion.identity);
                    goalPlaced = true;
                }
            }
        }

        if (!goalPlaced)
        {
            Vector3 fallbackPos = new Vector3(width - 1, 0.1f, height - 1);
            Instantiate(goalPrefab, fallbackPos, Quaternion.identity);
        }
    }
}
