using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

// Tutorial used: https://www.youtube.com/watch?v=GQzW6ZJFQ94&t=641s

public class SliceObject : MonoBehaviour
{
    public Transform startSlicePoint;
    public Transform endSlicePoint;
    public VelocityEstimator velocityEstimator;
    public LayerMask sliceableLayer;

    public Material sliceMaterial;
    public float sliceForce = 2000f;

    void FixedUpdate()
    {
        bool sliceHit = Physics.Linecast(startSlicePoint.position, endSlicePoint.position, out RaycastHit hit, sliceLayer);

        if (sliceHit)
        {
            GameObject target = hit.transform.gameObject;
            Slice(target);
        }
    }

    public void Slice(GameObject target)
    {
        Vector3 velocity = velocityEstimator.GetVelocityEstimate();
        Vector3 planeNormal = Vector3.Cross(endSlicePoint.position - startSlicePoint.position, velocity);
        planeNormal.Normalize();

        SlicedHull hull = target.Slice(endSlicePoint.position, planeNormal);

        if(hull != null)
        {
            GameObject upperHull = hull.CreateUpperHull(target, sliceMaterial);
            SliceComponent(upperHull);

            GameObject lowerHull = hull.CreateLowerHull(target, sliceMaterial);
            SliceComponent(lowerHull);

            Destroy(target);
        }
    }

    public void SliceComponent(GameObject slicedObject)
    {
        Rigidbody rb = slicedObject.AddComponent<Rigidbody>();
        MeshCollider collider = slicedObject.AddComponent<MeshCollider>();
        collider.convex = true;
        rb.AddExplosionForce(sliceForce, slicedObject.transform.position, 1f);
    }
}
