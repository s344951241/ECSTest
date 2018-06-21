using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class RotateSystem : ComponentSystem {
	struct Components
	{
		public Rotator rotator;
		public Transform transform;
	}
	
	protected override void OnUpdate()
	{
        foreach (var item in GetEntities<Components>())
        {
            item.transform.Rotate(0f, item.rotator.speed * Time.deltaTime, 0f);
        }

    }

}



