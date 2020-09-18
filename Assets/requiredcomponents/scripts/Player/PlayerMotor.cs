using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMotor : MonoBehaviour
{
    private CharacterController _character;
    [SerializeField]private float sidelimit;
    private Vector3 _position = Vector3.zero;

    public float speed = 2; //TODO: Remove after power


    private void Start()
    {
        _character = GetComponent<CharacterController>();
        _character.detectCollisions = true;
    }

    public void Moveplayer(float horizontalvalue)
    {
        _position.x = Maprange(horizontalvalue)*speed;
        _character.SimpleMove(_position);
    }

    private float Maprange(float inputvalue)
    {
        return inputvalue * sidelimit;
    }
}
