using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    
    [SerializeField]
    private Vector3 direction = Vector3.zero;

    // Update is called once per frame
    private void Update()
    {
        transform.position += direction * (speed * Time.deltaTime);
    }
    
    public void MoveTo(Vector2 direction)
    {
        this.direction = direction;
    }
}
