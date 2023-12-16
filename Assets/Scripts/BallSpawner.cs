using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 2f;
    public float ballSpeed = 5f;

    void Start()
    {
        StartCoroutine(SpawnBalls());
    }

    IEnumerator SpawnBalls()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            GameObject newBall = Instantiate(ballPrefab, new Vector3(-0.28f, 4f, -13.01f), Quaternion.identity);
            Rigidbody rb = newBall.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(Random.Range(-1f, 1f), -1f, 0f).normalized * ballSpeed;
        }
    }
}