using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _directionMove;
    
    private void Update()
    {
        transform.Translate(_directionMove * Time.deltaTime);
    }
}
