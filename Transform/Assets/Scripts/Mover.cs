using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _directionMove;
    
    void Update()
    {
        transform.Translate(_directionMove);
    }
}
