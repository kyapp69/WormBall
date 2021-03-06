﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	[SerializeField] Vector3 rotationVec;

	Transform initParent;

	void Awake()
	{
		initParent = transform.parent;
	}

	void Update()
	{
		if( !initParent )
		{
			Destroy( gameObject );
		}
		else
		{
			transform.position = initParent.position;
			transform.rotation *= Quaternion.Euler( rotationVec );

			if( transform.parent )
			{
				transform.parent = null;
				transform.localScale = Vector3.one * 1.25f;
			}
		}
	}
}
