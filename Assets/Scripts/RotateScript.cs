using UnityEngine;

public class RotateScript : MonoBehaviour
{

    public Transform world;

    public float rotationSpeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        world = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        world.Rotate(new Vector3(0, rotationSpeed, 0), Space.World);
    }
}
