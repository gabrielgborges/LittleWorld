using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
public class PlayerData : ScriptableObject
{
	[SerializeField]
	private float _verticalSpeed;
	[SerializeField]
	private float _horizontalSpeed;

	public float HorizontalSpeed
	{
		get { return _horizontalSpeed; }
	}

	public float VerticalSpeed
	{
		get { return _verticalSpeed; }
	}
}
