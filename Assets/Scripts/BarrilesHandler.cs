using UnityEngine;

public class BarrilesHandler : MonoBehaviour
{
    [SerializeField] GameObject barriles_prefab;
    private GameObject current_barriles_go;

    public void RespawnBarriles()
    {
        if (current_barriles_go != null)
        {
            Destroy(current_barriles_go);
        }
        current_barriles_go = Instantiate(barriles_prefab);
    }
}
