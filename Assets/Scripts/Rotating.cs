using UnityEngine;

public class Rotating : MonoBehaviour
{
   
    [SerializeField] private Vector3 _rotationSpeed ;
    
    private void Update()
    {
        transform.Rotate(_rotationSpeed*Time.deltaTime);
    }
}
