using KartGame.KartSystems;
using UnityEngine;
using static KartGame.KartSystems.ArcadeKart;

public class GenericSurfaceModifier : MonoBehaviour
{
    [SerializeField] StatPowerup powerUp;
    [SerializeField] bool removeOnExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ArcadeKart arcadeKart = other.transform.parent.GetComponent<ArcadeKart>();
            if (arcadeKart != null)
            {
                powerUp.ElapsedTime = 0;
                arcadeKart.AddPowerup(powerUp);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ArcadeKart arcadeKart = other.transform.parent.GetComponent<ArcadeKart>();
            if (arcadeKart != null)
            {
                if(removeOnExit)
                    arcadeKart.RemovePowerUp(powerUp);
            }
        }
    }
}
