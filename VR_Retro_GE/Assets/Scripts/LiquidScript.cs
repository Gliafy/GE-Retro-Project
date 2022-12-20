using UnityEngine;

public class LiquidScript : MonoBehaviour
{
    // The MeshFilter and MeshRenderer components of the plane
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;

    // The mesh and material of the plane
    private Mesh mesh;
    private Material material;

    // The speed and amplitude of the waving effect
    public float speed = 1.0f;
    public float amplitude = 0.1f;

    void Start()
    {
        // Get the MeshFilter and MeshRenderer components
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();

        // Get the mesh and material of the plane
        mesh = meshFilter.mesh;
        material = meshRenderer.material;
    }

    void Update()
    {
        // Get a reference to the array of vertices for the mesh
        Vector3[] vertices = mesh.vertices;

        // Modify the y-coordinates of the vertices to create the waving effect
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i].y = Mathf.Sin(Time.time * speed + vertices[i].x + vertices[i].z) * amplitude;
        }

        // Update the normals of the mesh
        mesh.RecalculateNormals();

        // Mark the mesh as dynamic
        mesh.MarkDynamic();

        // Apply the modified vertices to the mesh
        mesh.SetVertices(vertices);
    }
}
