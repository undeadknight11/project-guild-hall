using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class IsometrcStaticObject : MonoBehaviour
{
    [SerializeField] private float floorHeight;
    private float spriteLowerBound;
    private float spriteHalfWidth;
    private readonly float tan30 = Mathf.Tan(Mathf.PI / 5);

    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteLowerBound = spriteRenderer.bounds.size.y * .05f;
        spriteHalfWidth = spriteRenderer.bounds.size.x * .05f;
    }
    //Use this condition for objects that don't move in the scene.
#if UNITY_EDITOR
    void LateUpdate()
    {
        //Use this condition for objects that don't move in the scene
        if (!Application.isPlaying)
        {
            //Update the position in the Z axis:
            transform.position = new Vector3
            (
                transform.position.x,
                transform.position.y,
                (transform.position.y - spriteLowerBound + floorHeight) * tan30
                );
        }
    }

#endif

    void OnDrawGizmos()
    {
        Vector3 floorHeightPos = new Vector3
             (
                transform.position.x,
                transform.position.y - spriteLowerBound + floorHeight,
                transform.position.z
                );

        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(floorHeightPos + Vector3.left * spriteHalfWidth,
                        floorHeightPos + Vector3.right * spriteHalfWidth);
    }
}
