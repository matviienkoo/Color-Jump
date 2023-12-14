using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] birds;
    [SerializeField] GameObject player;
    [SerializeField] float spawnInterval;
    private Vector2 spawnPosRight, spawnPosLeft;
    private Camera cam;
    public int int_dead;

    // Start is called before the first frame update
    void Start()
    {
        if (Camera.main == null) { Debug.LogError("Camera.main not found, failed to create edge colliders"); return; }

        cam = Camera.main;
        if (!cam.orthographic) { Debug.LogError("Camera.main is not Orthographic, failed to create edge colliders"); return; }

        StartCoroutine(SpawnBirds());
    }

    private IEnumerator SpawnBirds()
    {
        if (int_dead == 0)
        {
        while (true)//while the game is not over
        {
            int num = Random.Range(0, 2);
            if (num == 0)
                SpawnOnRight();
            else
                SpawnOnLeft();
            
            yield return new WaitForSeconds(spawnInterval);
        }
        }
    }
    private void SpawnOnRight()
    {
        if (int_dead == 0)
        {
        spawnPosRight = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0f, cam.nearClipPlane));
        int i = Random.Range(0, birds.Length);
        Instantiate(birds[i], new Vector2(spawnPosRight.x, player.transform.position.y + 1.5f), new Quaternion(0f, 90f, 0f, 0f)); ;
        }
    }
    private void SpawnOnLeft()
    {   
        if (int_dead == 0)
        {
        spawnPosLeft = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, 0f, cam.nearClipPlane));
        int i = Random.Range(0, birds.Length);
        Instantiate(birds[i], new Vector2(spawnPosLeft.x, player.transform.position.y + 1.5f), Quaternion.identity);
        }
    }

    private void Update ()
    {
        int_dead = PlayerPrefs.GetInt("int_dead");
    }

}
