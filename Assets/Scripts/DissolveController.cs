using UnityEngine;
public class DissolveController : MonoBehaviour
{
    public Renderer rend;
    public float dissolveSpeed = 1f;
    public GameObject effect;
    private float _disolveAmount = 1f;
    private bool _dissolving = false;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _dissolving = !_dissolving;
            
            if (effect != null)
            {
                effect.SetActive(true);
            }
        }
        if (_dissolving == true)
        {
            _disolveAmount = Mathf.MoveTowards(_disolveAmount, 0f, dissolveSpeed * Time.deltaTime);
        }
        else
        {
            _disolveAmount = Mathf.MoveTowards(_disolveAmount, 1f, dissolveSpeed * Time.deltaTime);
        }
        rend.material.SetFloat("_Cutoff", _disolveAmount);
        
        if (_disolveAmount <= .5f)
        {
            rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        }
        else
        {
            rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }
}
