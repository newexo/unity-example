using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Polygon 
{
	public static List<Vector3> Vertices(int n, float r = 1)
	{
		var answer = new List<Vector3> ();
		for(int i = 0; i < n; i++)
		{
			float theta = 2 * Mathf.PI * i / n;
			answer.Add (new Vector3 (r * Mathf.Cos (theta), 0, r * Mathf.Sin (theta)));
		}
		return answer;
	}

	public static GameObject[] CloneAtVertices(Transform parent, GameObject prefab, int n, float r = 1)
	{
		var clones = new GameObject[n];
		int i = 0;
		foreach(var vertex in Vertices (n, r))
		{
			var clone = GameObject.Instantiate (prefab);
			clone.transform.parent = parent;
			clone.transform.localPosition = vertex;
			clones [i] = clone;
			i++;
		}
		return clones;
	}
}
