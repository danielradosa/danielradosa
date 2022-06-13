using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class colorChange : MonoBehaviour
{
	public static GameObject[] objToFind;
	private Renderer[] blockRenderer;
	private Color newBaseColor;
	private float randomChannelOne, randomChannelTwo, randomChannelThree;

	void Start()
	{
		gameObject.GetComponent<Button>().onClick.AddListener(ChangeBaseColor);
	}

	void ChangeBaseColor()
	{
		objToFind = GameObject.FindGameObjectsWithTag("Frame");
		blockRenderer = new Renderer[objToFind.Length];
		for (int i = 0; i < objToFind.Length; i++)
		{
			blockRenderer[i] = objToFind[i].GetComponent<Renderer>();
		}
		for (int i = 0; i < objToFind.Length; i++)
		{
			newBaseColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
			blockRenderer[i].material.color = newBaseColor;
		}
	}
}