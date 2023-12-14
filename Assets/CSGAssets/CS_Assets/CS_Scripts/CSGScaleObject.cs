using UnityEngine;
using System.Collections;

public class CSGScaleObject : MonoBehaviour
{
	public GameObject rotater;
	public bool bool_rotater;

    private void Start() 
    {
    	StartCoroutine(ChangeScale());
    }

    IEnumerator ChangeScale ()
    {
    	yield return new WaitForSeconds(1f);
    	rotater.gameObject.transform.localScale = new Vector3(0.69f, 0.62f, 0.70f);

        yield return new WaitForSeconds(1f);
        rotater.gameObject.transform.localScale = new Vector3(0.85f, 0.77f, 0.85f);
        StartCoroutine(ChangeScale());
    }
}