using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    private int _bulletsPerShot = 3;
    private float _spreadAngle = 10f;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            float angle = _spreadAngle * (i - _bulletsPerShot / 2f);
            Vector2 direction = Quaternion.Euler(0, 0, angle) * Vector2.left;
            Bullet newBullet = Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            newBullet.SetDirection(direction);
        }
    }
}

