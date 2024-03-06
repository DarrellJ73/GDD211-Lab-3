using UnityEngine;

public class Player : MonoBehaviour
{
    // Common properties for all players
    protected float health = 100f;
    protected Vector2 respawnPosition;

    // Common method for all players to take damage
    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Respawn();
        }
    }

    // Common method for all players to respawn
    public virtual void Respawn()
    {
        transform.position = respawnPosition;
        health = 100f;
    }
}

public class Warrior : Player
{
    // Warrior-specific properties or methods
    private float attackDamage = 20f;

    // Warrior-specific attack method
    public void Attack()
    {
        // Perform attack logic
        Debug.Log("Warrior attacks!");
    }

    // Override the base class's TakeDamage method for custom behavior
    public override void TakeDamage(float damage)
    {
        // Additional warrior-specific logic for taking damage
        base.TakeDamage(damage);
        Debug.Log("Warrior takes damage!");
    }
}

public class Mage : Player
{
    // Mage-specific properties or methods
    private float spellDamage = 30f;

    // Mage-specific attack method
    public void CastSpell()
    {
        // Perform spell casting logic
        Debug.Log("Mage casts a spell!");
    }

    // Override the base class's TakeDamage method for custom behavior
    public override void TakeDamage(float damage)
    {
        // Additional mage-specific logic for taking damage
        base.TakeDamage(damage);
        Debug.Log("Mage takes damage!");
    }
}

