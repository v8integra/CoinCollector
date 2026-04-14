using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float rotateSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

  private void FixedUpdate()
  {
    transform.Rotate(0, 0, rotateSpeed);
  }
}
