using UnityEngine;
public class DissolveController : MonoBehaviour
{
    public Renderer rend;
    public float dissolveSpeed = 1f;
    private float _disolveAmount = 1f;
    private bool dissolving = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            dissolving = !dissolving;
        }
        if (dissolving == true)
        {
            _disolveAmount = Mathf.MoveTowards(_disolveAmount, 0f, dissolveSpeed * Time.deltaTime);
        }
        else
        {
            _disolveAmount = Mathf.MoveTowards(_disolveAmount, 1f, dissolveSpeed * Time.deltaTime);
        }
        rend.material.SetFloat("_Cutoff", _disolveAmount);
    }
}
