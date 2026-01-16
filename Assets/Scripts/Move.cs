using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject redCube;
    public float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    public void MoveMe()
    {
        redCube.transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}
