using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class PolygonSpecs 
{
	readonly float epsilon = 1e-6f;
	[Test]
	public void square()
	{
		var expected = new List<Vector3> {
			new Vector3(2, 0, 0),
			new Vector3(0, 0, 2),
			new Vector3(-2, 0, 0),
			new Vector3(0, 0, -2)
		};
		var actual = Polygon.Vertices (4, 2);
		Assert.AreEqual (0, (expected[0] - actual[0]).magnitude, epsilon);
		Assert.AreEqual (0, (expected[1] - actual[1]).magnitude, epsilon);
		Assert.AreEqual (0, (expected[2] - actual[2]).magnitude, epsilon);
		Assert.AreEqual (0, (expected[3] - actual[3]).magnitude, epsilon);
	}

	[Test]
	public void triangle()
	{
		var expected = new List<Vector3> {
			new Vector3(1, 0, 0),
			new Vector3(Mathf.Cos(2 * Mathf.PI / 3), 0, Mathf.Sin(2 * Mathf.PI / 3)),
			new Vector3(Mathf.Cos(4 * Mathf.PI / 3), 0, Mathf.Sin(4 * Mathf.PI / 3))
		};
		var actual = Polygon.Vertices (3);
		Assert.AreEqual (0, (expected[0] - actual[0]).magnitude, epsilon);
		Assert.AreEqual (0, (expected[1] - actual[1]).magnitude, epsilon);
		Assert.AreEqual (0, (expected[2] - actual[2]).magnitude, epsilon);
	}
}
