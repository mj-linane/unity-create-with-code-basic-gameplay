using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode
{
    public class PlayerInBounds
    {
        [UnityTest]
        public IEnumerator CheckXLimits()
        {
            // create a new game object and add the Player controller script
            var player = new GameObject().AddComponent<PlayerController>();
            // get player from hierarchy and make sure their left and right bounds on x are limited from -10 to 10;
            // if player x < -10, then their x position should be -10, if their position is > 10, then their x position should be 10.
            // Check negative bounds
            player.transform.position = new Vector3(-11, 0, 0);
            yield return new WaitForSeconds(1);
            Assert.AreEqual(-10, player.transform.position.x);
            // Check positive bounds
            player.transform.position = new Vector3(11, 0, 0);
            yield return new WaitForSeconds(1);
            Assert.AreEqual(10, player.transform.position.x);
        }
    }
}
