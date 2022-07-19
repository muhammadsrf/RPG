using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;
        [SerializeField] string dieParameter = "die";

        bool isDead = false;

        public bool IsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            Die();
            print($"darah : {healthPoints}");
        }

        private void Die()
        {
            if (isDead) { return; }
            if (healthPoints == 0)
            {
                GetComponent<Animator>().SetTrigger(dieParameter);
                isDead = true;
            }
        }
    }
}