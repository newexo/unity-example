using UnityEngine;
using System.Collections;

public class PolygonController : MonoBehaviour
{
	public float n = 3;
	public float r = 3;
	float oldr;
	public GameObject prefab;

	GameObject[] vertices;

	void Start () {
		vertices = Polygon.CloneAtVertices (transform, prefab, (int) n, r);	
		oldr = r;
	}
	
	void Update () {
		int m = (int) n;
		if (m != vertices.Length || oldr != r) {
			for (int i = 0; i < vertices.Length; i++)
				Destroy (vertices [i]);
			vertices = Polygon.CloneAtVertices (transform, prefab, m, r);
			oldr = r;
		}
	}
}
