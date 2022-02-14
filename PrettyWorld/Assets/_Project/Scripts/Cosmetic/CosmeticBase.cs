using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticBase : MonoBehaviour
{
	[SerializeField]
	protected CosmeticData _data;

	public CosmeticData Data
	{
		get { return _data; }
	}
}
