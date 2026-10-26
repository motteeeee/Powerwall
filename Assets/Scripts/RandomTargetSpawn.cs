using UnityEngine;

public class RandomTargetSpawn : MonoBehaviour
{
    // Hier ziehst du im Inspector das Target-Prefab rein
    public GameObject targetPrefab;

    void Start()
    {
        // Beim Start einmal ein Ziel erzeugen
        spawnTarget();
    }

    // public, damit ColorChange es später aufrufen kann
    public void spawnTarget()
    {
        // Zufällige Position zwischen (-2.5, 0, -2.5) und (2.5, 0, 2.5)
        Vector3 randomPos = new Vector3(
            Random.Range(-2.5f, 2.5f),
            0f,
            Random.Range(-2.5f, 2.5f)
        );

        // Ziel als Kind des Skriptträgers (der Plane) erzeugen
        GameObject target = Instantiate(targetPrefab, transform);
        target.transform.localPosition = randomPos;
    }
}