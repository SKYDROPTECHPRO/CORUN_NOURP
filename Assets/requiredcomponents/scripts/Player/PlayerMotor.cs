using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMotor : MonoBehaviour
{
    private CharacterController _character;
    [SerializeField]private float sidelimit;
    private Vector3 _position = Vector3.zero;
    private PlayerPower _power;

    public float speed = 2; //TODO: Remove after power


    private void Awake()
    {
        _character = GetComponent<CharacterController>();
        _character.detectCollisions = true;
        _power = GetComponent<PlayerPower>();
    }

    public void Moveplayer(float horizontalvalue)
    {
        _position.x = Maprange(horizontalvalue)*_power.movespeed_hor;
        _character.SimpleMove(_position);
    }

    private float Maprange(float inputvalue)
    {
        return inputvalue * sidelimit;
    }
}
