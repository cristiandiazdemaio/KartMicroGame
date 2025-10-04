using KartGame.KartSystems;
using UnityEngine;
using static KartGame.KartSystems.ArcadeKart;

public class GenericSurfaceColliderMod : MonoBehaviour
{
    [SerializeField] StatPowerup powerUp;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ArcadeKart arcadeKart = other.gameObject.GetComponentInParent<ArcadeKart>();
            if (arcadeKart != null)
            {
                arcadeKart.AddPowerup(powerUp);
            }
        }
    }
}
