using UnityEngine;

public class InputManager : A_InputHandler
{
    [SerializeField] private string horizontalaxis="Horizontal";
    [SerializeField] private KeyCode mask = KeyCode.M;
    [SerializeField] private KeyCode sanitizer = KeyCode.N;
    [SerializeField] private KeyCode medication = KeyCode.B;
    [SerializeField] private KeyCode energydrink = KeyCode.V;
    public override float getinput()
    {
        if (Input.GetKeyDown(mask))
        {
            OnApplymask();
        }
        
        if (Input.GetKeyDown(sanitizer))
        {
            OnApplysanitizer();
        }
        
        if (Input.GetKeyDown(medication))
        {
            OnApplymedication();
        }
        
        if (Input.GetKeyDown(energydrink))
        {
            OnApplyenergydrink();
        }
        
        return Input.GetAxis(horizontalaxis);
    }
}
