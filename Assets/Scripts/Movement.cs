using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 8;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(1,0,0) * Time.deltaTime * speed);
    }
}
