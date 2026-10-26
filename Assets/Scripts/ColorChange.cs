using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Wird in 4.4 im Inspector verlinkt (die Plane)
    public RandomTargetSpawn targetSpawner;

    // Merkt sich den Renderer, damit wir die Farbe ändern können
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }

    // Würfel fährt INS Ziel
    void OnTriggerEnter(Collider other)
    {
        rend.material.color = Color.green;

        // Parent des Ziels = die Plane mit dem RandomTargetSpawn-Skript
        RandomTargetSpawn spawner = other.transform.parent.GetComponent<RandomTargetSpawn>();

        // Falls das nicht klappt, das verlinkte Objekt nehmen
        if (spawner == null)
        {
            spawner = targetSpawner;
        }

        spawner.spawnTarget();
    }

    // Würfel fährt AUS dem Ziel raus
    void OnTriggerExit(Collider other)
    {
        rend.material.color = Color.blue;
        Destroy(other.gameObject);
    }
}