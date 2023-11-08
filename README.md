# TranquilNest
A VR experience that simulates a soothing environnment and allows you to access sensory experiences to relax yourself

## Important ! Travaillez sur votre propre scène (celle avec votre nom), vous pouvez en recréer aussi mais ne pas travailler à plusieurs sur la même scène, sinon RIP le repo

## Code convention :
<p>
  https://unity.com/how-to/naming-and-code-style-tips-c-scripting-unity

 ### exemple : 
  ```
// EXAMPLE: Public and private variables

public float DamageMultiplier = 1.5f;
public float MaxHealth;
public bool IsInvincible;

private bool _isDead;
private float _currentHealth;

// parameters
public void InflictDamage(float damage, bool isSpecialDamage)
{
    // local variable
    int totalDamage = damage;

    // local variable versus public member variable
    if (isSpecialDamage)
    {
    	totalDamage *= DamageMultiplier;
    }

    // local variable versus private member variable
    if (totalDamage > _currentHealth)
    {
        /// ...
    }
}
  ```
</p>
