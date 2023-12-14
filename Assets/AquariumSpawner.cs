using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquariumSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] squidward;
    [SerializeField] GameObject player;
    [SerializeField] float spawnIntervalAquarium;
    private Vector2 spawnPosRight;
    private Camera cam;
    public int int_dead;

    // Start is called before the first frame update
    void Start()
    {
        if (Camera.main == null) { Debug.LogError("Camera.main not found, failed to create edge colliders"); return; }

        cam = Camera.main;
        if (!cam.orthographic) { Debug.LogError("Camera.main is not Orthographic, failed to create edge colliders"); return; }

        StartCoroutine(SpawnSquid());
    }

    private IEnumerator SpawnSquid()
    {
        if (int_dead == 0)
        {
        while (true)//while the game is not over
        {
            int num = Random.Range(0, 2);
            if (num == 0)
                SpawnOnTop();
            
            yield return new WaitForSeconds(spawnIntervalAquarium);
        }
        }
    }
    private void SpawnOnTop()
    {
        if (int_dead == 0)
        {
        spawnPosRight = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0f, cam.nearClipPlane));
        int i = Random.Range(0, squidward.Length);
        Instantiate(squidward[i], new Vector2(spawnPosRight.x, player.transform.position.y + -1f), new Quaternion(0f, 90f, 160f, 60f)); ;
        }
    }

    private void Update ()
    {
        int_dead = PlayerPrefs.GetInt("int_dead");
    }

}
